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
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }


        int x = 0;

        private void contactsPanel_Paint(object sender, PaintEventArgs e)
        {
            string UserInfo = "blank user info";
            string Status = "activity";
            int n = 8; // Število edinstvenih klepetov v DB
            if (x == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Button button = new Button();
                    button.Size = new Size(215, 45);
                    button.BackColor = Color.LightGray;
                    button.FlatStyle = FlatStyle.Flat;

                    button.Text = UserInfo + "  " + Status; 
                    button.Tag = i;
                    button.Name = "UserInfo" + i;

                    contactsPanel.Controls.Add(button);
                    x++;
                }
            }

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
        /* /Premikanje forme*/
        
    }
}
