using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HangmanConsoleChallenge.UI
{
    public class ProgramUI
    {

        public string pOneName;
        public string pTwoName;
        public int pOneScore = 0;
        public int pTwoScore = 0;
        public static string[] gameWords = new string[]
        { "sheep",
          "optimal",
          "quiet",
          "watermelon",
          "cake",
          "nondescript",
          "lettuce",
          "few",
          "excellent",
          "defeated"
        };
        //Random rando = new Random();
        //public int randomNumber = rando.Next(0, gameWords.Length);
        //public string randoWord = gameWords.ElementAt(randomNumber);

        string guessWord = "optimal";



        public void Run()
        {
            RunGame();
        }

        private void RunGame()
        {
            int wordLength = guessWord.Length; 
            string wordShadow = "_" * guessWord.Length;

            for(int i = 0; i < guessWord.Length; i++)
            {
                wordShadow += '_';
            }
            Console.WriteLine("Please enter your guess:");
            string guess = Console.ReadLine();
            
          if (guessWord.Contains(guess))
            {

            }

         

            



            Console.WriteLine("Enter player one's name");
            pOneName = Console.ReadLine();
            Console.WriteLine("Enter player two's name");
            pTwoName = Console.ReadLine();
        }
    }
}








