using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class GuessTheWord:Game
    {
        public string hideLetters(string randomWord)
        { //Moves the random word into an array of chars
            char[] wordHiddenLet = new char[randomWord.Length];
            int i = 0;
            foreach (char letter in randomWord)
            {
                wordHiddenLet[i] = letter;
                i++;
            }
            Random random = new Random();
            int index = 0;
            int numOfHidden = 0;
            while(numOfHidden < wordHiddenLet.Length/2)
            {//Randomly hides 1/2 of the letters within the random word and changes it back to a string sending it to the class that called it.
                index = random.Next(0, wordHiddenLet.Length - 1);
                if(char.IsLetter(wordHiddenLet[index]))
                {
                    wordHiddenLet[index] = '-'; 
                numOfHidden = numOfHidden + 1;
                }
                else
                {}
            }

            return new String(wordHiddenLet);
        }
    }
}
