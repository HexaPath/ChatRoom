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
    public partial class AddChatbudy : Form
    {
        public AddChatbudy()
        {
            InitializeComponent();
        }

        /* Dizajn
         * Textboxes
            Usertxtbox          //Noter je vpisan username uporabnika, katerega profil je potrebno prikazat
            Chattxtbox          //Noter je vpisano ime klepetalnice v katero se povezuješ
            ChatCreatetxtbox    //Noter je vpisano ime klepetalnice kateroo želiš narediti
         * Buttons
            btnUserEnter        // Sproži iskalni poziv (SQL), kjer iz baze izvrže podatke uporabnika 
            btnRoomEnter
            btnRoomCreate
        */

        private void btnUserEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnRoomEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnRoomCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
