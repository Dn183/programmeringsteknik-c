using System;
using System.Collections.Generic;
using System.Linq;

namespace vowelapp
{
    class Program
    {
        char[] _vowels;
        
        public char[] Vowels { get; set;}

        static void Main(string[] args)
        {
            // Skriv en konsolapplikation som tar bort vokaler (konstigt va?) från en inmatad sträng.
            // Applikationen skall både presentera den resulterande strängen och antalet vokaler som togs bort.

            char[] vowels = new char[] { 'a', 'e', 'o', 'i', 'u', 'y', 'å', 'ä', 'ö' };

            Console.WriteLine("Skriv en stäng: ");
            var input = Console.ReadLine().ToLower();
            var output = new List<char>();
            int removedCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentCharacter = input[i];
                var normalizedCharacter = char.ToLower(currentCharacter);

                if (vowels.Contains(currentCharacter) == false)
                {
                    output.Add(currentCharacter);
                }
                else
                {
                    removedCount++;
                }
            }


            var resultingString = new string(output.ToArray());

            Console.WriteLine($"Din sträng utan vokaler '{resultingString}', vi tog bort {removedCount} st.");

        }
    }
}
