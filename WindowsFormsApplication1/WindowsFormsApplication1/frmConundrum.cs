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
    public partial class frmConundrum : Form
    {
        public string difficulty;
        public int attempts = 5;
        Conundrum conundrum = new Conundrum();
        string randomWord;
        public frmConundrum()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            // Checks if the word is correct, (Converting it to lower case to ensure that the guess is in the same format as the word, giving relavent feedback)
            string guess = txtGuess.Text;
            guess = guess.ToLower();
            if (randomWord == guess)
            {
                if (MessageBox.Show("Well Done, you were correct. Would you like to try again?", "Correct", MessageBoxButtons.OKCancel) == DialogResult.OK) //Message box to appear when user is correct
                {
                    List<string> wordList = conundrum.getWordList(difficulty);
                    randomWord = conundrum.getRandomWord(wordList, wordList.Count);
                    lblScrambleWord.Text = conundrum.wordScramble(randomWord);
                    lblScrambleWord.Refresh();
                    resetAttempts();
                }
                else
                {
                    frmMainMenu mainMenu = new frmMainMenu();
                    mainMenu.Show();
                    this.Close();
                }
            }
            else
                if (attempts > 1)
                {
                    MessageBox.Show("You were incorrect, please try again."); //Message box to appear if user is incorrect (Attempts > 1)
                    updateAttempts();
                }
                else
                {
                    updateAttempts();
                    if (MessageBox.Show("You have ran out of attempts. The correct word is " + randomWord + ". Would you like to try again?", "Incorrect", MessageBoxButtons.OKCancel) == DialogResult.OK)//Message box to appear if user is incorrect (Attempts <= 1)
                    {
                        List<string> wordList = conundrum.getWordList(difficulty);
                        randomWord = conundrum.getRandomWord(wordList, wordList.Count);
                        lblScrambleWord.Text = conundrum.wordScramble(randomWord);
                        lblScrambleWord.Refresh();
                        resetAttempts();
                    }
                    else
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
        }

        public void updateAttempts()
        { //Subtracts one from number of remaining attempts and then changes the label on the form to relect this
            attempts--;
            lblRemainingAttempts.Text = "Attempts Remaining: " + attempts;
            lblRemainingAttempts.Refresh();
        }
        public void resetAttempts()
        { //Resets nunber of attempts to 5 to allow for a new game of Conundrum to be played
            attempts = 5;
            lblRemainingAttempts.Text = "Attempts Remaining: " + attempts;
            lblRemainingAttempts.Refresh();
        }

        private void frmConundrum_Load(object sender, EventArgs e)
        {//Uses the Conundrum class to get the word list, random word and scrambled word to use for the game
            List<string> wordList = conundrum.getWordList(difficulty);
            randomWord = conundrum.getRandomWord(wordList, wordList.Count);
            lblScrambleWord.Text = conundrum.wordScramble(randomWord); // Displays the scrambled word
            lblScrambleWord.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        { //returns user to main manu
            frmMainMenu MainMenu = new frmMainMenu();
            MainMenu.Show();
            this.Close();
        }
        private void frmConundrum_FormClosing(Object sender, FormClosingEventArgs e)
        { //Ensures that program closes if the last form is closed
            FormCollection fc = Application.OpenForms;
            if (fc.Count == 2)
                Application.Exit();
        }
    }
}
