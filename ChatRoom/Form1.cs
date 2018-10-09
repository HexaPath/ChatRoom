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
            username = idTextBox.Text;
            password = passTextBox.Text;
            if (username != "" && password != "")
            {
                // Registriraj uporabnika v bazo
                // input username, password
                //"INPUT "
            }
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            username = idTextBox.Text;
            password = passTextBox.Text;
            if (username != "" && password != "")
            {
                // Chech, če že obstaja
                // definiranje baze MySql

                //"SELECT id FROM users WHERE EXIST((user = '"+ username +"') AND (pass = '"+ password +"') = 1);";
            }
        }

        private void idTextBox_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
        }

        private void passTextBox_Click(object sender, EventArgs e)
        {
            passTextBox.Text = "";
        }
    }
}
