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
    public partial class frmGuessTheWord : Form
    {
        public string difficulty;
        GuessTheWord guessTheWord = new GuessTheWord();
        int attempts = 5;
        string randomWord;
        int timeLeft = 60;
        
        public frmGuessTheWord()
        {
            InitializeComponent();
        }

        private void frmGuessTheWord_Load(object sender, EventArgs e)
        { //Uses Guess the word class to get word list, random word and then hide letters from the word, displaying the word with hidden letters on the form
            List<String> wordList = guessTheWord.getWordList(difficulty);
            randomWord = guessTheWord.getRandomWord(wordList, wordList.Count);
            lblScrambleWord.Text = guessTheWord.hideLetters(randomWord);
            lblScrambleWord.Refresh();
            timer1.Enabled = true;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        { //// Checks if the word is correct, (Converting it to lower case to ensure that the guess is in the same format as the word, giving relavent feedback)
            string correctLetters = "";
            int index = 0;
            string hiddenLetters = lblScrambleWord.Text;
            string guess = txtGuess.Text;
            guess = guess.ToLower();
            if (guess.Length == randomWord.Length)
            {
                foreach (char letter in guess) // updates hidden letters so that all correct letters are displayed
                {
                    if (char.IsLetter(hiddenLetters[index]))
                    {
                        correctLetters = correctLetters + hiddenLetters[index];
                        index++;
                    }
                    else
                    {
                        if (letter == randomWord[index])
                        {
                            correctLetters = correctLetters + letter;
                            index++;
                        }
                        else
                        {
                            correctLetters = correctLetters + "-";
                            index++;
                        }
                    }
                }

                if (correctLetters == randomWord) // if all letters are now displayed then it is consider a correct word.
                {
                    lblScrambleWord.Text = correctLetters;
                    lblScrambleWord.Refresh();
                    if (MessageBox.Show("Well Done, you were correct. Would you like to try again?", "Correct", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        List<string> wordList = guessTheWord.getWordList(difficulty);
                        randomWord = guessTheWord.getRandomWord(wordList, wordList.Count);
                        lblScrambleWord.Text = guessTheWord.hideLetters(randomWord);
                        lblScrambleWord.Refresh();
                        resetAttempts();
                        timerReset();
                        guessReset();
                    }
                    else
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
                else
                {
                    if (attempts > 1) //letters have been updated but word isn't correct (Attempts lowered and incorrect message displayed)
                    {
                        lblScrambleWord.Text = correctLetters;
                        lblScrambleWord.Refresh();
                        MessageBox.Show("You were incorrect, please try again. The word has been updated to show correct letters");
                        updateAttempts();
                        guessReset();
                    }
                    else// Ran out of attempts
                    {
                        updateAttempts();
                        if (MessageBox.Show("You have ran out of attempts. The correct word is " + randomWord + ". Would you like to try again?", "Incorrect", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            List<string> wordList = guessTheWord.getWordList(difficulty);
                            randomWord = guessTheWord.getRandomWord(wordList, wordList.Count);
                            lblScrambleWord.Text = guessTheWord.hideLetters(randomWord);
                            lblScrambleWord.Refresh();
                            resetAttempts();
                            timerReset();
                            guessReset();
                        }
                        else
                        {
                            frmMainMenu mainMenu = new frmMainMenu();
                            mainMenu.Show();
                            this.Close();
                        }
                    }
                }
            }
            else // Guess too long or not long enough
            {
                if (attempts > 1)
                {
                    MessageBox.Show("You must guess a full word.");
                    updateAttempts();
                }
                else
                {
                    updateAttempts();
                    if (MessageBox.Show("You have ran out of attempts. The correct word is " + randomWord + ". Would you like to try again?", "Incorrect", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        List<string> wordList = guessTheWord.getWordList(difficulty);
                        randomWord = guessTheWord.getRandomWord(wordList, wordList.Count);
                        lblScrambleWord.Text = guessTheWord.hideLetters(randomWord);
                        lblScrambleWord.Refresh();
                        resetAttempts();
                        timerReset();
                        guessReset();
                    }
                    else
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
            }
        }
        public void updateAttempts()
        { //Subtracts one from updates
            attempts--;
            lblRemainingAttempts.Text = "Attempts Remaining: " + attempts;
            lblRemainingAttempts.Refresh();
        }
        public void resetAttempts()
        {//Resets attempt to 5
            attempts = 5;
            lblRemainingAttempts.Text = "Attempts Remaining: " + attempts;
            lblRemainingAttempts.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {//Takes user back to main menu
            frmMainMenu MainMenu = new frmMainMenu();
            MainMenu.Show();
            this.Close();
        }
        private void timerReset()
        { //resets timer to 60
            timeLeft = 60;
            lblTimeRemaining.Text = "Time Remaining: " + timeLeft;
            lblTimeRemaining.Refresh();
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
        }
        private void guessReset()
        {//Resets txtGuess.Text to allow for new guess
            txtGuess.Text = "";
            txtGuess.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {// checks if there is still time remaining if not then it will tell the user they are out of time
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimeRemaining.Text = "Time Remaining: " + timeLeft;
                lblTimeRemaining.Refresh();
            }
            else
            {
                timer1.Enabled = false;
                if (MessageBox.Show("You have ran out of time. The correct word is " + randomWord + ". Would you like to try again?", "Incorrect", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    List<string> wordList = guessTheWord.getWordList(difficulty);
                    randomWord = guessTheWord.getRandomWord(wordList, wordList.Count);
                    lblScrambleWord.Text = guessTheWord.hideLetters(randomWord);
                    lblScrambleWord.Refresh();
                    resetAttempts();
                    timerReset();
                    guessReset();
                }
                else
                {
                    frmMainMenu mainMenu = new frmMainMenu();
                    mainMenu.Show();
                    this.Close();
                }
            }
        }
        private void frmGuessTheWord_FormClosing(Object sender, FormClosingEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            if (fc.Count == 2)
                Application.Exit();
        }
    }
}
