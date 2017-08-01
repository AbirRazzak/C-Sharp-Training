using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                playGame();
                Console.WriteLine("Will you like to keep playing? Y/N");
                String answer = Console.ReadLine();
                if (answer == "N" || answer == "n") keepGoing = false;
            }
           
        }

        public static void playGame()
        {
            Console.WriteLine("******************************"
                        + "\n WELCOME TO THE ANAGRAM GAME!"
                        + "\n******************************"
                        + "\n"
                        + "Please write your first word to begin!");

            Console.Write("First word: ");
            String word1;
            word1 = Console.ReadLine();

            Console.Write("Second word: ");
            String word2;
            word2 = Console.ReadLine();

            if (areAnagrams(word1, word2)) Console.WriteLine("Your words are anagrams!");
            else Console.WriteLine("Your words are not anagrams.");
        }

        public static String sortWord(String word)
        {
            char[] characters = word.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }

        public static bool areAnagrams(String a, String b)
        {
            if (sortWord(a) == sortWord(b))
            {
                return true;
            }
            else return false;
        }
    }
}

/* Notes from the author:
 * 
 * This game IS case sensitive (captial letters must match up and vise versa)
 * This game IS also space sensitive (both "word" must have the same number of spaces)
 * Using the same word does count
 * When asked to play again, the game will reset no matter what you type in unless it is 'N' or 'n'
 * 
 */