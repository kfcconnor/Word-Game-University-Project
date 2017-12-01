using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    abstract class Game
    {
        public List<String> getWordList(string difficulty)
        {// Loads word list creating a list of the words within it and returning it to the class that called it
            string filePath;
            string wordList;
            int maxWords = 0;

            filePath = Directory.GetCurrentDirectory() + "\\WordList\\" + difficulty + ".txt";
            wordList = File.ReadAllText(filePath);

            List<String> possibleWords = new List<string>();
            String currentWord = "";
            bool wordStarted = false;

            foreach(char letter in wordList)
            {
                if (char.IsLetter(letter) == true)
                {
                    currentWord = currentWord + letter;
                    wordStarted = true;
                }
                else
                {
                    if (wordStarted == true)
                    {
                        possibleWords.Add(currentWord);
                        currentWord = "";
                        maxWords = maxWords + 1;
                        wordStarted = false;
                    }
                    else
                    {

                    }
                }
            }
            possibleWords.Add(currentWord);
            currentWord = "";
            maxWords = maxWords + 1;
            return possibleWords;
        }

            public string getRandomWord(List<String> possibleWords, int maxWords)
            {// Gets the word list gotten by another class and chooses a single random word from it, returning it to the class that called it
                string randomWord;
                int randomWordIndex;
                Random random = new Random();
                randomWordIndex = random.Next(0, maxWords - 1);

                randomWord = possibleWords[randomWordIndex];
                return randomWord;
            }

            

    }
}
