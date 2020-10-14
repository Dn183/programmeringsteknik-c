using System;
using System.Collections.Generic;
using System.Linq;

namespace vowelapp
{
    class Program
    {
<<<<<<< HEAD
        char[] _vowels;
        
        public char[] Vowels { get; set;}
=======
        private char[] _vowels;

        public char[] Vowels { get; set; }
>>>>>>> 51cf2a2b05f9887f869fae78fa8220545ca071fc

        static void Main(string[] args)
        {
            // Skriv en konsolapplikation som tar bort vokaler (konstigt va?) från en inmatad sträng.
            // Applikationen skall både presentera den resulterande strängen och antalet vokaler som togs bort.

            char[] vowels = new char[] { 'a', 'e', 'o', 'i', 'u', 'y', 'å', 'ä', 'ö' };

<<<<<<< HEAD
            Console.WriteLine("Skriv en stäng: ");
            var input = Console.ReadLine().ToLower();
=======
            Console.Write("Skriv en sträng: ");
            var input = Console.ReadLine();
>>>>>>> 51cf2a2b05f9887f869fae78fa8220545ca071fc
            var output = new List<char>();
            int removedCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentCharacter = input[i];
                var normalizedCharacter = char.ToLower(currentCharacter);

<<<<<<< HEAD
                if (vowels.Contains(currentCharacter) == false)
=======
                if (vowels.Contains(normalizedCharacter) != true)
>>>>>>> 51cf2a2b05f9887f869fae78fa8220545ca071fc
                {
                    output.Add(currentCharacter);
                }
                else
                {
                    removedCount++;
                }
            }

<<<<<<< HEAD

            var resultingString = new string(output.ToArray());

            Console.WriteLine($"Din sträng utan vokaler '{resultingString}', vi tog bort {removedCount} st.");

=======
            var resultingString = new string(output.ToArray());
            
            Console.WriteLine($"Din sträng utan vokaler: '{resultingString}', vi tog bort: {removedCount} st.");
>>>>>>> 51cf2a2b05f9887f869fae78fa8220545ca071fc
        }
    }
}
