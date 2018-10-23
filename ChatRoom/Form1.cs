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

        class DBConnect
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public DBConnect()
    {
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {
        server = "localhost";
        database = "connectcsharptomysql";
        uid = "username";
        password = "password";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

    //open connection to database
    private bool OpenConnection()
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
    private bool CloseConnection()
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
    public void Insert()
    {
    }

    //Update statement
    public void Update()
    {
    }

    //Delete statement
    public void Delete()
    {
    }

    //Select statement
    public string Select()
    {
    }

    //Count statement
    public int Count()
    {
    }
}





        public string user = "";
        string pass = "";

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            user = idtextbox.Text;
            pass = passtextbox.Text;
            int userid = 0;
            if (user != "" && pass != "")
            {
                // Registriraj uporabnika v bazo
                // input username, password as user, pass
                //"SELECT id FROM users WHERE (name = '"+ username +"');";
               
                if(userid == 0) {
                    //"INSERT INTO users (name, pass) VALUES ('"+ username +"' , '"+ password +"'); ";
                }
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
