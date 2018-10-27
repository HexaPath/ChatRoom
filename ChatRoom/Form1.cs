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
        /*Na novo definirano*/
        public static int user_id = 0;
        public static int role = 0;
        public static string user_name = "";
        string user_password = "";
        public static int direction_log = 0;

        /*Hash Funkcija*/ // Ne si neki glave razbijat... Tole dela, tiho pa ponuci
        public static class SHA
        {
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
        
        /* Database*/ // Vse povezave na server mySql
        class DBConnect
        {
            // Primarne spremenljivke
            private MySqlConnection connection;
            private string server_address;
            private string server_database;
            private string server_user;
            private string server_password;
            // Sekundarne spremenljivke
            string salt = "Qv6SPSihsU7WkED5RS9yoKYseiqm5dcLD0TXIP0Im6nRz5TTbs1f5Ti9MxyO92sWfnwMZlQDLCHDUuXCOqUSZQlpuYiGxemQ9zFFXGBrmsHAdgJOqf5e6gP0j15XRE69Zv8PsPP8KmU0w2X76r4MCVLHrb8744SLlJBX7tsO4hJ52GsMdnhxF4pWMI7wDDPsFiryOtyo4hPqGqyetArygzbYzpEC5nn7A1hgii3Or0ZLGdshqpecf7hF40BAhw6l";
            string query = "";
            string secure_password = "";
 
            //Constructor
            public DBConnect()
            {
                Initialize();
            }

            private void Initialize() // Nastavljanje podatkov podatkovne baze / hosta
            {
                server_address = "localhost";
                server_database = "HexaPath_HexaPath_Database_no1";
                server_user = "root"; //"HexaPath";
                server_password = ""; //"GesloGeslo";
                string connectionString;
                connectionString =  "SERVER=" + server_address + ";" + 
                                    "DATABASE=" +  server_database + ";" + 
                                    "UID=" + server_user + ";" + 
                                    "PASSWORD=" + server_password + ";"; 
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
                    //When handling errors, you can your application's response based on the error number.
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

            //Close connection to database
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
            public void UserInsert(string user_name, string user_password)  
            {
                int unique = 0; // Preverjam, da se user še ne nahaja v bazi
                if (this.OpenConnection() == true)
                {
                        query = "SELECT COUNT(*) " +
                                "FROM users " +
                                "WHERE(username = '" + user_name + "')";
                    
                    MySqlCommand comm = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = comm.ExecuteReader();
                    while (dataReader.Read())  { unique = dataReader.GetInt32(0); } 

                    dataReader.Close();
                    this.CloseConnection();
                }

                else {MessageBox.Show("Baza se ni odprla"); }

                if (unique == 0)
                {
                    secure_password = SHA.GenerateSHA512String(salt + user_password + salt);
                    query = "INSERT INTO users (username, password, role_id) " +
                            "VALUES('" + user_name + "', '" + secure_password + "', 0)";
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        cmd.ExecuteNonQuery();
                        this.CloseConnection(); 
                    }
                    direction_log = 3;
                }

                else { MessageBox.Show("User Already Exists. Try Contacting Admin Or Create New Profile"); }
            }        
            
            //Select statement
            public void UserSelec(string user_name, string user_password)
            {
                string database_password = "";
                user_id = 0;
                role = 0;
                secure_password = SHA.GenerateSHA512String(salt + user_password + salt);
                query = "SELECT id, username, password, role_id " +
                        "FROM users " +
                        "WHERE (username = '" + user_name + "')";
                
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection); //definiranje nove povezave - Magic
                    MySqlDataReader dataReader = cmd.ExecuteReader();       //definiranje branja        - Magic

                    while (dataReader.Read())
                    {
                        user_id = dataReader.GetInt32(0);
                        user_name = dataReader.GetString(1);
                        database_password = dataReader.GetString(2); 
                        role = dataReader.GetInt32(3);
                    }

                    dataReader.Close(); // Zapri branje
                    this.CloseConnection(); //Zapri povezave
                     
                    if (database_password == secure_password)   // je geslo iz baze isto geslu iz forme ?
                    {
                        direction_log = 3;
                    }
                }
                else { MessageBox.Show("Sorry, it aint gonna work like that. Check your UserID Select to fix this error"); }
            }
        }
  
        private void direction()    // Funkcija, da se znebim ponavljanja v gumbih, pošlje naprej na insert / select / new form
        {
            user_name = idtextbox.Text;
            user_password = passtextbox.Text;
            if (user_name != "" && user_password != "")
            {
                DBConnect conn = new DBConnect();
                if(direction_log == 1)
                {
                    conn.UserInsert(user_name, user_password);
                    if (direction_log == 3)
                    {
                        newform();
                    }
                    else { MessageBox.Show("Vnos ni bil mogoč"); }
                }
                else if(direction_log == 2)
                { 
                    conn.UserSelec(user_name, user_password);
                    if (direction_log == 3)
                    {
                        newform();
                    }
                    else { MessageBox.Show("Prijava ni bila mogoča"); }
                }
            }
        }

        private void newform()
        {
            chat mainform = new chat();
            this.Hide();
            mainform.Show();
        }

        /* Forma */
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            direction_log = 1;
            direction();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            direction_log = 2;
            direction();
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
