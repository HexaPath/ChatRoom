using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string username = "";
        string password = "";

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            username = idtextbox.Text;
            password = passtextbox.Text;
            int userid = 0;
            if (username != "" && password != "")
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
            username = idtextbox.Text;
            password = passtextbox.Text;
            if (username != "" && password != "")
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
