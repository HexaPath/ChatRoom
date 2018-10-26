using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;


namespace ChatRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int UserID = 0;
        public static string user = "";
        public static int role = 0;
        string pass = "";

        /*HashStuff - the copy paste part*/

        public static class SHA
        {

            public static string GenerateSHA256String(string inputString)
            {
                SHA256 sha256 = SHA256Managed.Create();
                byte[] bytes = Encoding.UTF8.GetBytes(inputString);
                byte[] hash = sha256.ComputeHash(bytes);
                return GetStringFromHash(hash);
            }

            public static string GenerateSHA512String(string inputString)
            {
                SHA512 sha512 = SHA512Managed.Create();
                byte[] bytes = Encoding.UTF8.GetBytes(inputString);
                byte[] hash = sha512.ComputeHash(bytes);
                return GetStringFromHash(hash);
            }

            private static string GetStringFromHash(byte[] hash)
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    result.Append(hash[i].ToString("X2"));
                }
                return result.ToString();
            }

        }

        /*HashStuff*/
        ///////////
        ///////////
        //////////


        /*
         Screwing around with database
        */
        class DBConnect
        {
            private MySqlConnection connection;
            private string server;
            private string database;
            private string uid;
            private string password;
            public string salt = "Qv6SPSihsU7WkED5RS9yoKYseiqm5dcLD0TXIP0Im6nRz5TTbs1f5Ti9MxyO92sWfnwMZlQDLCHDUuXCOqUSZQlpuYiGxemQ9zFFXGBrmsHAdgJOqf5e6gP0j15XRE69Zv8PsPP8KmU0w2X76r4MCVLHrb8744SLlJBX7tsO4hJ52GsMdnhxF4pWMI7wDDPsFiryOtyo4hPqGqyetArygzbYzpEC5nn7A1hgii3Or0ZLGdshqpecf7hF40BAhw6l";

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "HexaPath_HexaPath_Database_no1";
            uid = "root";//"HexaPath";
            password = "";//"GesloGeslo";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";"; 
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection() 
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                        //When handling errors, you can your application's response based 
                        //on the error number.
                        //The two most common error numbers when connecting are as follows:
                        //0: Cannot connect to server.
                        //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                    MessageBox.Show("Cannot connect to server.  Contact administrator");
                    break;

                    case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
                }
            return false;
            }
        }

            //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

            //Insert statement
            public void Insert(string user, string pass)  
            {
                int usernumber = 0;
                string query = "";
                if (this.OpenConnection() == true)
                {
                    query = "SELECT COUNT(*) FROM users WHERE(username = '" + user + "')";
                    
                    MySqlCommand comm = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = comm.ExecuteReader();

                    while (dataReader.Read())
                    {
                        usernumber = dataReader.GetInt32(0);
                    }
                    //close Data Reader
                    dataReader.Close();
                    
                    //close Connection
                    this.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Baza se ni odprla");
                }

                if(usernumber == 0)
                {
                    string Ipassword = salt + pass + salt;
                    string HashedPassword = SHA.GenerateSHA512String(Ipassword); 

                    query = "INSERT INTO users (username, password, role_id) VALUES('" + user + "', '" + HashedPassword + "', 0)";
                    //open connection
                    if (this.OpenConnection() == true)
                    {
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        //Execute command
                        cmd.ExecuteNonQuery();

                        //close connection
                        this.CloseConnection();
                         
                    }
                }
                else
                {
                    MessageBox.Show("User Already Exists. Try Contacting Admin Or Create New Profile");
                }
            }


            //Select statement
            public void SelectUser(string user, string pass)
            {

                string Ipassword = salt + pass + salt; //password = SHA512(password);  //treba je še hashat;
                string HashedPassword = SHA.GenerateSHA512String(Ipassword); 
                string query = "SELECT id, username, password, role_id FROM users " +
                "WHERE (username = '" + user + "')";
                int UserID = 0;
                string dbpassword = "";
                role = 0;

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader(); 
                    while (dataReader.Read())
                    {
                        UserID = dataReader.GetInt32(0);
                        user = dataReader.GetString(1); 
                        dbpassword = dataReader.GetString(2); 
                        role = dataReader.GetInt32(3);
                    }
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                     
                    if (dbpassword == HashedPassword)
                    { 
                        //Do something now
                    }
                }
                else { MessageBox.Show("Sorry, it aint gonna work like that. Check your UserID Select to fix this error"); }
            }
        }
  

    /*Done with DataBases... Now, to shell*/




    private void btnRegistracija_Click(object sender, EventArgs e)
        {
            user = idtextbox.Text;
            pass = passtextbox.Text;
            if (user != "" && pass != "")
            {
                DBConnect conn = new DBConnect();
                conn.Insert(user, pass);
            }
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            user = idtextbox.Text;
            pass = passtextbox.Text;
            if (user != "" && pass != "")
            {
                DBConnect conn = new DBConnect();
                conn.SelectUser(user, pass);
            }
        }

        private void idTextBox_Click(object sender, EventArgs e)
        {
            idtextbox.Text = "";
        }

        private void passTextBox_Click(object sender, EventArgs e)
        {
            passtextbox.Text = "";
        }

        public void newform()
        { 
            /*chat mainform = new chat();                                                                                                           // definiraj formo the end kot glavno formo
            this.Hide();                                                                                                                                        // skrij to formo
            mainform.Show();*/
            //Pošlji v chat formo
        }
    }
}
