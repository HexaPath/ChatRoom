using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ChatRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int UID = 0;
        public static string user = "";
        string pass = "";

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
                password = salt + pass + salt; 
                //treba je še hashat
                string query = "INSERT INTO users (username, password) VALUES('"+ user +"', '"+ password +"') " +
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
                public void SelectUser(string user)
                {
                    string query = "SELECT id, user, password, role FROM users WHERE (username = '" + user + "')";
                    //Create a list to store the result
                    int UID = 0;
                    int role = 0; 

                    //Open connection
                    if (this.OpenConnection() == true)
                    {
                        //Create Command
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        //Create a data reader and Execute the command
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        //Read the data and store them in the list
                        while (dataReader.Read())
                        {
                            UID = dataReader.GetInt32(0);
                            role = dataReader.GetInt32(3);
                        }

                        //close Data Reader
                        dataReader.Close();

                        //close Connection
                        this.CloseConnection();
                    
                    }
                    else{ MessageBox.Show("Sorry, it aint gonna work like that. Check your UID Select to fix this error"); }
                }
            

            //Update statement
            public void Update()    //No values at this time
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
            } 
        }





        

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
                // Chech, če že obstaja
                // definiranje baze MySql

                //"SELECT COUNT(id) FROM users WHERE ((name = '"+ username +"') AND (pass = '"+ password +"'));";
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
    }
}
