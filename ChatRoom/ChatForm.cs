﻿using System;
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
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        string User_Info = "blank user info";       // name od userja
        int User_id = LoginForm.user_id;            // id od userja
        string Room_Info = "blank room info";       // name od chatrooma
        int Room_id = 0;                            // id od chatrooma
        int contact_user_id = 0;
        int UserStatusOverride = 0;
        int ContactStatusOverride = 0;
        int ResetVariableX = 0;
        string dbTime = "30. 10. 2018 13:07:00"; // placeholder

        class DBConnect
        {
            // Primarne spremenljivke
            private MySqlConnection connection;
            private string server_address;
            private string server_database;
            private string server_user;
            private string server_password;
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
                connectionString = "SERVER=" + server_address + ";" +
                                    "DATABASE=" + server_database + ";" +
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

            
            // Update timestamp / override
            public void TimestampUpdate(int user_id, int Override)
            {
                string query = "UPDATE users SET timestamp = '" + DateTime.Now + "',override_id = '" + Override + "' WHERE id = '" + user_id + "' ";
                     
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }

            // Select interaction user count from database
            public int GetUsersCount(int user_id)
            {
               int count = 0;
                string query = "SELECT COUNT(DISTINCT users.id) FROM users, messages_private, friend_system " +
                                "WHERE(((users.id = messages_private.reciever_id) AND(messages_private.sender_id = '" + user_id + "') AND(messages_private.reciever_id != '" + user_id + "')) " +
                                "OR((users.id = messages_private.sender_id) AND(messages_private.reciever_id = '" + user_id + "') AND(messages_private.sender_id != '" + user_id + "'))) " +
                                "OR(((users.id = friend_system.user1_id) AND(friend_system.user2_id = '" + user_id + "') AND(friend_system.user1_id != '" + user_id + "')) " +
                                "OR((users.id = friend_system.user2_id) AND(friend_system.user1_id = '" + user_id + "') AND(friend_system.user2_id != '" + user_id + "'))) " +
                                "LIMIT 1";
               
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection); //definiranje nove povezave - Magic
                    MySqlDataReader dataReader = cmd.ExecuteReader();       //definiranje branja        - Magic
                    dataReader.Read();
                    count = dataReader.GetInt32(0);
                    //MessageBox.Show(Convert.ToString(count));
                    dataReader.Close(); // Zapri branje
                    this.CloseConnection(); //Zapri povezave 
                    return count;
                }
                else { MessageBox.Show("Sorry, it aint gonna work like that. Check your Friends to fix this error"); return 0; }
            }
            // Get Username
            public string GetUsersUsername(int id, int i)
            {
                string username = "Blank"; 
                string query = "SELECT DISTINCT users.username FROM users, messages_private, friend_system " +
                                "WHERE(((users.id = messages_private.reciever_id) AND(messages_private.sender_id = '" + id + "') AND(messages_private.reciever_id != '" + id + "')) " +
                                "OR((users.id = messages_private.sender_id) AND(messages_private.reciever_id = '" + id + "') AND(messages_private.sender_id != '" + id + "'))) " +
                                "OR(((users.id = friend_system.user1_id) AND(friend_system.user2_id = '" + id + "') AND(friend_system.user1_id != '" + id + "')) " +
                                "OR((users.id = friend_system.user2_id) AND(friend_system.user1_id = '" + id + "') AND(friend_system.user2_id != '" + id + "')))" +
                                "ORDER BY users.id DESC LIMIT " + i + " , 1 ";
                //MessageBox.Show(query);
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection); //definiranje nove povezave - Magic
                    MySqlDataReader dataReader = cmd.ExecuteReader();       //definiranje branja        - Magic
                    dataReader.Read();
                    username = dataReader.GetString(0);
                    dataReader.Close(); // Zapri branje
                    this.CloseConnection(); //Zapri povezave 
                    return username;
                }
                else { return "Error"; }
            }
            // Get ID
            public int GetUsersId(int id, int i)
            {
                int IdentificationNumber = 0;
                string query = "SELECT DISTINCT users.id FROM users, messages_private, friend_system " +
                                "WHERE(((users.id = messages_private.reciever_id) AND(messages_private.sender_id = '" + id + "') AND(messages_private.reciever_id != '" + id + "')) " +
                                "OR((users.id = messages_private.sender_id) AND(messages_private.reciever_id = '" + id + "') AND(messages_private.sender_id != '" + id + "'))) " +
                                "OR(((users.id = friend_system.user1_id) AND(friend_system.user2_id = '" + id + "') AND(friend_system.user1_id != '" + id + "')) " +
                                "OR((users.id = friend_system.user2_id) AND(friend_system.user1_id = '" + id + "') AND(friend_system.user2_id != '" + id + "')))" +
                                "ORDER BY users.id DESC LIMIT " + i + " , 1 ";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection); //definiranje nove povezave - Magic
                    MySqlDataReader dataReader = cmd.ExecuteReader();       //definiranje branja        - Magic
                    dataReader.Read();
                    IdentificationNumber = dataReader.GetInt32(0);
                    dataReader.Close(); // Zapri branje
                    this.CloseConnection(); //Zapri povezave 
                    return IdentificationNumber;
                }
                else { return 0; }
            }
            // StatusBar
            public int ActivicyCheck_Override(int id)
            {
                int Override = 0;
                string query = "SELECT override_id FROM users WHERE id = '" + id + "'";
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection); //definiranje nove povezave - Magic
                    MySqlDataReader dataReader = cmd.ExecuteReader();       //definiranje branja        - Magic
                    dataReader.Read();
                    Override = dataReader.GetInt32(0);
                    dataReader.Close(); // Zapri branje
                    this.CloseConnection(); //Zapri povezave 
                    return Override;
                }
                else { return 0; }
                
            }
            public string ActivicyCheck_DateTime(int id)
            {
                string datetime = "";
                string query = "SELECT timestamp FROM users WHERE id = '" + id + "'";
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection); //definiranje nove povezave - Magic
                    MySqlDataReader dataReader = cmd.ExecuteReader();       //definiranje branja        - Magic
                    dataReader.Read();
                    datetime = dataReader.GetString(0);
                    dataReader.Close(); // Zapri branje
                    this.CloseConnection(); //Zapri povezave 
                    return datetime;
                }
                else { return ""; }
            }

            // Select room user has joined to
            public int GetRoomCount(int id)
            {
                int count = 0;
                string query = "SELECT COUNT(DISTINCT id) FROM participants WHERE user_id = '"+ id +"'";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection); //definiranje nove povezave - Magic
                    MySqlDataReader dataReader = cmd.ExecuteReader();       //definiranje branja        - Magic
                    dataReader.Read();
                    count = dataReader.GetInt32(0);
                    //MessageBox.Show(Convert.ToString(count));
                    dataReader.Close(); // Zapri branje
                    this.CloseConnection(); //Zapri povezave 
                    return count;
                }
                else { MessageBox.Show("Sorry, it aint gonna work like that. Check your Friends to fix this error"); return 0; }
            }

            public int GetRoomId(int id, int i)
            {
                int IdentificationNumber = 0;
                string query = "SELECT room_id FROM participants WHERE user_id = '" + id + "'  ORDER BY id DESC LIMIT " + i + ",1";
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection); //definiranje nove povezave - Magic
                    MySqlDataReader dataReader = cmd.ExecuteReader();       //definiranje branja        - Magic
                    dataReader.Read();
                    IdentificationNumber = dataReader.GetInt32(0);
                    dataReader.Close(); // Zapri branje
                    this.CloseConnection(); //Zapri povezave 
                    return IdentificationNumber;
                }
                else { return 0; } 
            }
            public string GetRooms(int id, int i)
            {
                string username = "Blank";
                string query = "SELECT r.name FROM participants p" +
                                "INNER JOIN rooms r ON p.room_id = r.id" +
                                "WHERE user_id = '" + id + "'  ORDER BY r.id DESC LIMIT " + i + ",1";
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection); //definiranje nove povezave - Magic
                    MySqlDataReader dataReader = cmd.ExecuteReader();       //definiranje branja        - Magic
                    dataReader.Read();
                    username = dataReader.GetString(0);
                    dataReader.Close(); // Zapri branje
                    this.CloseConnection(); //Zapri povezave 
                    return username;
                }
                else { return "Error"; }
            }

            //Search constantly when typing with like
            public void search (string searchtext)
            {
                string query = "(SELECT username, id, '1' AS type FROM users WHERE(username LIKE '%" + searchtext + "%'))" +
                                "UNION " +
                                "(SELECT name, id, '2' AS type FROM rooms WHERE(name LIKE '%" + searchtext + "%'))";
                string name = "";
                int id = 0;
                int type = 0;
                string tip = "";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection); //definiranje nove povezave - Magic
                    MySqlDataReader dataReader = cmd.ExecuteReader();       //definiranje branja        - Magic

                    while (dataReader.Read())
                    {
                        name = dataReader.GetString(0);
                        id = dataReader.GetInt32(1);
                        type = dataReader.GetInt32(2);
                        if(type == 1) { tip = "user"; }
                            else if(type == 2) { tip = "room"; }
                            else { tip = "zafuku si"; }
                        MessageBox.Show(name + " " + Convert.ToString(id) + " " + tip);
                    }

                    dataReader.Close(); // Zapri branje
                    this.CloseConnection(); //Zapri povezave

                }
                else { MessageBox.Show("Sorry, it aint gonna work like that. Check your UserID Select to fix this error"); }
            }
        }






        
        private void contactsPanel_Paint(object sender, PaintEventArgs e)
        { 
            if (ResetVariableX == 0)
            {
                DBConnect conn = new DBConnect();
                int n = conn.GetUsersCount(User_id);
                for (int i = 0; i < n; i++)
                {
                    Button button = new Button();                       // Mal dizajna
                    button.Size = new Size(215, 45);                    // Mal dizajna
                    button.BackColor = Color.LightGray;                 // Mal dizajna
                    button.FlatStyle = FlatStyle.Flat;                  // Mal dizajna
                    button.Click += new EventHandler(ButtonClickOneEvent);  //Gumbu naredim funkcionalnost
                    User_Info = conn.GetUsersUsername(User_id, i);      // Izpis iz baze... username
                    button.Text = User_Info ;                            
                    contact_user_id = conn.GetUsersId(User_id, i);      // Izpis iz baze...  id
                    button.Name = Convert.ToString(contact_user_id);    
                    contactsPanel.Controls.Add(button);                 // Gumb naredi na panelo
                    ResetVariableX++;                                   // Da se forma ne posodablja konstantno
                }

                DBConnect com = new DBConnect();
                int y = com.GetRoomCount(User_id);
                for (int i = 0; i < y; i++)
                {
                    Button groupbutton = new Button();                       // Mal dizajna
                    groupbutton.Size = new Size(215, 45);                    // Mal dizajna
                    groupbutton.BackColor = Color.LightBlue;                 // Mal dizajna
                    groupbutton.FlatStyle = FlatStyle.Flat;                  // Mal dizajna
                    groupbutton.Click += new EventHandler(groupButtonClickOneEvent);  //Gumbu naredim funkcionalnost
                    Room_Info = conn.GetRooms(User_id, i);      // Izpis iz baze... username
                    groupbutton.Text = Room_Info;
                    Room_id = conn.GetRoomId(User_id, i);      // Izpis iz baze...  id
                    groupbutton.Name = Convert.ToString(contact_user_id);
                    contactsPanel.Controls.Add(groupbutton);                 // Gumb naredi na panelo
                    ResetVariableX++;                                   // Da se forma ne posodablja konstantno
                }
            }
        }

        void groupButtonClickOneEvent(object sender, EventArgs e) // Kaj naredi gumb za chatroom
        {
            Button button = sender as Button;
            Room_id = Convert.ToInt32(button.Name);
            Room_Info = button.Text;
            UserInfoPanel.Visible = true;
            ContactInfoLabel.Text = Room_Info;
            Contact_status_onlineBtn.Visible = false;
            Contact_status_inactiveBtn.Visible = false;
            Contact_status_offlineBtn.Visible = false;
        }


        void ButtonClickOneEvent(object sender, EventArgs e) // Kaj dejansko naredi novonastali gumb...
        {
            Button button = sender as Button;
            contact_user_id = Convert.ToInt32(button.Name);
            User_Info = button.Text; 
            UserInfoPanel.Visible = true;
            ContactInfoLabel.Text = User_Info;
            Contact_status_onlineBtn.Visible = false;
            Contact_status_inactiveBtn.Visible = false;
            Contact_status_offlineBtn.Visible = false;

            DBConnect conn = new DBConnect();
            ContactStatusOverride = conn.ActivicyCheck_Override(contact_user_id);
            dbTime = conn.ActivicyCheck_DateTime(contact_user_id);
            //MessageBox.Show(dbTime);
            TimeSpan diff = DateTime.Now - DateTime.Parse(dbTime); 
            double minute = diff.TotalMinutes; 
            if (ContactStatusOverride == 1 || ContactStatusOverride == 0)
            {
                if(minute >= 0 && minute <= 10)
                {
                    Contact_status_onlineBtn.Visible = true;
                } 
                else if (minute >= 11 && minute <= 30)
                {
                    Contact_status_inactiveBtn.Visible = true;
                }
                else if(minute > 30)
                {
                    Contact_status_offlineBtn.Visible = true;
                }
            }
            else if(ContactStatusOverride == 2)
            {
                Contact_status_inactiveBtn.Visible = true;
            }
            else if (ContactStatusOverride == 3)
            {
                Contact_status_offlineBtn.Visible = true;
            }
        }

        
        private void ActivicyChecker()
        {
            DBConnect conn = new DBConnect();
            conn.TimestampUpdate(User_id, UserStatusOverride);
            UserStatusOverride = 0;
        }

        private void User_status_onlineBtn_Click(object sender, EventArgs e)
        {
            UserStatusOverride = 1;
            ActivicyChecker();
        }
        private void User_status_inactiveBtn_Click(object sender, EventArgs e)
        {
            UserStatusOverride = 2;
            ActivicyChecker();
        }
        private void User_status_offlineBtn_Click(object sender, EventArgs e)
        {
            UserStatusOverride = 3;
            ActivicyChecker();
        }

        /*Premikanje forme*/
        int mouseX = 0, mouseY = 0;
        bool mousedown;
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
        
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousedown)
            {
                mouseX = MousePosition.X -500;
                mouseY = MousePosition.Y ;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MessagetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendBtn_Click(object sender, EventArgs e) // Pošiljanje stringa v text-message
        {
            string message_send_now = MessagetextBox.Text;
            string time = Convert.ToString(DateTime.Now);
            MessagetextBox.Text = "";
            MessageBox.Show("Tole bo kazalo na desni strani chatboxa, ko bo delalo seveda " + message_send_now);
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            string s = searchtextBox.Text;
            if (s != "")
            {
                DBConnect conn = new DBConnect();
                conn.search(s);
            }
            else { }
        }

        /* Zapiranje forme/aplikacije*/
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            int swansong = 3;
            DBConnect conn = new DBConnect(); 
            conn.TimestampUpdate(User_id, swansong);
            Application.Exit();
        }
    }
}
