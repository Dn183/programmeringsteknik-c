using System;
<<<<<<< HEAD
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
=======
using System.Globalization;
>>>>>>> 51cf2a2b05f9887f869fae78fa8220545ca071fc

namespace tgif
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en applikation som läser in ett datum via användarinmatning,
<<<<<<< HEAD
            // som sedan räknar ut hur många dagar det är till nästa fredag.
            //från det inmatade datumet

            DateTime date;
            while (!GetDateFromUser(out date));
=======
            // som sedan räknar ut hur många dagar det är till nästkommande fredag
            // från det inmatade datumet

            DateTime date;
            while(!GetDateFromUser(out date));
>>>>>>> 51cf2a2b05f9887f869fae78fa8220545ca071fc

            DayOfWeek givenDay = date.DayOfWeek;
            DayOfWeek friday = DayOfWeek.Friday;

            int difference = friday - givenDay;

            if (difference < 0)
                difference += 7;

            Console.WriteLine($"There are {difference} days until next friday");
        }

        static bool GetDateFromUser(out DateTime date)
        {
<<<<<<< HEAD
            Console.WriteLine("Enter a date");

=======
            Console.WriteLine("Enter a date: ");
>>>>>>> 51cf2a2b05f9887f869fae78fa8220545ca071fc
            string input = Console.ReadLine();

            CultureInfo culture = new CultureInfo("sv-SE");

            return DateTime.TryParse(input, culture, DateTimeStyles.AssumeLocal, out date);
        }
    }
}
