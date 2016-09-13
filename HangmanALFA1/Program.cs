using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAlfa
{
    class Program

        ///TEST SYNK Stefan
        //Test MF
        //Loveyomo123

        ///Test paggeluring
        /// Test Adrian123
    {
        static string playerName;
        static int lives = 7;
        static string attempts;
        static string word;
        static string guessedLetter;


        static void Main(string[] args)
        {

            Welcome();
            PlayerName();
            MenuStart();
            WordGenerator();
            CountLetters();
            CorrectLetter();
            ShowLetter();
            IncorrectLetter();
            ShowWrong();
            GameWon();
            GameLost();
            TryAgain();
            //GameEngine();
        }
        static void Welcome()
        {
            Console.WriteLine("Welcome to the award winning Hangman Game made by the Alpha Team");
            Console.ReadLine(); // Regler ska skrivas upp här

        }
        static void MenuStart()
        {
            // Låter spelaren välja mellan 1 och 2
            Console.WriteLine("1: Start");
            Console.WriteLine("2: How To");
            Console.WriteLine("3: Quit");
            string input = Console.ReadLine();
            int inputInt = int.Parse(input); // behöver felhantering

            switch(inputInt)
            {
                case 1: WordGenerator(); break;
                case 2: HowTo(); break;
                case 3: Quit(); break;
                default: Console.WriteLine("Choose 1,2 or 3!"); Console.ReadLine(); MenuStart(); break;
                    
            }
            Console.ReadLine();  // ska lägga till en if sats,
        }
        static void Quit()
        {
            // Credits avslutningsgrafik
            Environment.Exit(0);
        }
        static void PlayerName()
        {
            // Spelaren skriver in sitt namn och sparas
            Console.WriteLine("Enter your name");
            playerName = Console.ReadLine();
        }
        static void WordGenerator()
        {
            // ska slumpa ett ord från en ordbank, utvecklas senare med array när vi har fler ord
            word = "Healthy"; //byt till generator
        }
        static void Lives(bool letterCorrect)
        {
            // hanterar liven, utvecklas med if senare
            Console.WriteLine(letterCorrect);
        }
        static void CountLetters()
        {
            // presenterar antal bokstäver i ordet
            int wordCharacters = word.Length;
        }
        static void CorrectLetter()
        {
            Console.WriteLine("CorrectLetter");
            //Lives(true);
        }
        static void ShowLetter()
        {
            //Visar bokstäver som använts
            Console.WriteLine(guessedLetter);
            Console.ReadLine();
        }
        static void IncorrectLetter()
        {
            // Räknar ner liv
            Console.WriteLine("IncorrectLetter");
            //Lives(false);
            lives--;
            Console.WriteLine("You have " + lives + " lives left");
            Console.ReadLine();
        }

        static void ShowWrong()
        {
            // ska visa vilka bokstäver som är fel
        }

        static void GameLost()
        {
            // Visar ett meddelande om förlust
            Console.WriteLine("You are useless, you are a shame to the human kind " + playerName + "!");
            Console.ReadLine();
            TryAgain();
        }
        static void GameWon()
        {
            // Visar ett meddelande om vinst
            Console.WriteLine("Good job " + playerName + "!");
            Console.ReadLine();
            TryAgain();
        }
        static void TryAgain()
        {
            // Frågar om spelaren vill spela igen
            Console.WriteLine("Try again? Y/N");
            Console.ReadLine();
            // anropa quit eller meny
        }
        static void GameEngine()
        {
            // Kontrollerar spelares liv och gissningar i en loop till spelets slut (provosorisk)
            //
        }
        static void HowTo()
        {
            Console.WriteLine("Regler and shit");
            Console.ReadLine();
            MenuStart();
        }
    }

}





