using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMainMenu : Form
    {
        frmDifficulty difficulty = new frmDifficulty();
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnGuessTheWord_Click(object sender, EventArgs e)
        {
            // This sets the game to load as Guess the word and then shows the Difficulty form while hiding the menu form.
            difficulty.game = "Guess The Word";
            difficulty.Show();
            this.Hide();
        }

        private void btnConundrum_Click(object sender, EventArgs e)
        {
            // This sets the game to load as Conundrum and then shows the difficulty form while hiding the menu form
            difficulty.game = "Conundrum";
            difficulty.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // This closes the program
            Application.Exit();
        }

        private void frmMainMenu_FormClosing(Object sender, FormClosingEventArgs e)
        {
           // This will ensure the program closes when the last active form is closed
           FormCollection fc =  Application.OpenForms;
            if(fc.Count == 2)
            Application.Exit();
        }

        


    }
}
