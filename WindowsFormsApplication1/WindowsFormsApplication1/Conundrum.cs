using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Conundrum:Game
    {
        public string wordScramble(string randomWord)
        {//Changes the random word into an array chars, also creating a check word of the random word for later
            char[] scrambledWord = new char[randomWord.Length];
            string checkWord = randomWord;
            Random random = new Random();

            int index = 0;

            while (randomWord.Length > 0)
            {// scrambles the word until all the letters in the string are in the array of chars
                int next = random.Next(0, randomWord.Length - 1);

                scrambledWord[index] = randomWord[next];

                randomWord = randomWord.Substring(0, next) + randomWord.Substring(next + 1);

                index++;
            }
            string scrambleWord = new String(scrambledWord);
            if (scrambleWord == checkWord) 
            {// Checks scamble word against the word saved to check it if they are the same it runs the scrambler again.
                scrambleWord = wordScramble(checkWord);
            }
            return scrambleWord;
        }
    }
}
