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
    public partial class frmDifficulty : Form
    {
        frmConundrum Conundrum = new frmConundrum();
        frmGuessTheWord GuessTheWord = new frmGuessTheWord();
        public string game;
        public frmDifficulty()
        {
            InitializeComponent();
        }


        private void btnEasy_Click(object sender, EventArgs e)
        {
            // Depending on the game chosen on the main menu the diffculty would be passed to the game's form and then the form would be opened.
            if (game == "Conundrum")
            {
                Conundrum.difficulty = "Easy";
                Conundrum.Show();
                this.Close();
            }
            else if (game == "Guess The Word")
            {
                GuessTheWord.difficulty = "Easy";
                GuessTheWord.Show();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Will take the user back to the main
            frmMainMenu MainMenu = new frmMainMenu();
            MainMenu.Show();
            this.Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            // Depending on the game chosen on the main menu the diffculty would be passed to the game's form and then the form would be opened.
            if (game == "Conundrum")
            {
                Conundrum.difficulty = "Medium";
                Conundrum.Show();
                this.Close();
            }
            else if (game == "Guess The Word")
            {
                GuessTheWord.difficulty = "Medium";
                GuessTheWord.Show();
                this.Close();
            }
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            // Depending on the game chosen on the main menu the diffculty would be passed to the game's form and then the form would be opened.
            if (game == "Conundrum")
            {
                Conundrum.difficulty = "Hard";
                Conundrum.Show();
                this.Close();
            }
            else if (game == "Guess The Word")
            {
                GuessTheWord.difficulty = "Hard";
                GuessTheWord.Show();
                this.Close();
            }
        }

        private void frmDifficulty_FormClosing(Object sender, FormClosingEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            if (fc.Count == 2)
                Application.Exit();
        }

        private void frmDifficulty_Load(object sender, EventArgs e)
        {

        }
    }
}
