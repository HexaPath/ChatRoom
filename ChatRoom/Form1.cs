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
            server = "89.142.169.85";
            database = "HexaPath_HexaPath_Database_no1";
            uid = "HexaPath";
            password = "geslogeslo";
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
                string Ipassword = salt + pass + salt;
                //password = SHA512(password);  //treba je še hashat

                string query = "INSERT INTO users (username, password, role_id) VALUES('"+ user +"', '"+ Ipassword +"', 0) " +
                    "WHERE (SELECT COUNT(*) FROM users WHERE (username = '" + user + "') = 0;)";
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
                //Select statement
                public void SelectUser(string user, string pass)
                {
                
                    string Ipassword =salt + pass + salt; //password = SHA512(password);  //treba je še hashat;
                    string query = "SELECT id, user, password, role_id FROM users WHERE (username = '" + user + "')AND (password ='"+ Ipassword +"')";
                    
                    int UserID = 0;
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
                            password = dataReader.GetString(2);
                            role = dataReader.GetInt32(3);
                        }

                        //close Data Reader
                        dataReader.Close();

                        //close Connection
                        this.CloseConnection();
                    
                    }
                    else{ MessageBox.Show("Sorry, it aint gonna work like that. Check your UserID Select to fix this error"); }
                }
            

            //Update statement
           /* public void Update()    //No values at this time
            {
                string query = "UPDATE users SET password='' WHERE username = ''";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            } */
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
        
        private void nextform()
        {
            //Pošlji v chat formo
        }
    }
}
