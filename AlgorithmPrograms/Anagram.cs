using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Anagram
    {
        public void Check()
        {
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();
            //converting to character array
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);
            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Enterd words are anagrams");
            }
            else
            {
                Console.WriteLine("Enterd words are not anagrams");
            }
        }
       
    }
}
