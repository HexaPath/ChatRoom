﻿using System;
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
        /*Premikanje forme*/



    }
}
