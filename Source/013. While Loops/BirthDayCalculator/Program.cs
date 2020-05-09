using System;

using System.Globalization;

namespace BirthDayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();

            var usersDateOfBirth = AskForDateOfBirth();
        }

        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hi, I'm Savvy. " +
                "I'm really good at guessing the " +
                "day of the week you were born on.");
        }

        public static DateTimeOffset AskForDateOfBirth()
        {
            var dateOfBirth = DateTimeOffset.MaxValue;

            while (dateOfBirth > DateTimeOffset.UtcNow)
            {
                Console.WriteLine($"Can I start by asking you " +
                             $"what your date of birth is? { CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern }");

                var userText = Console.ReadLine();

                if (DateTimeOffset.TryParse(userText, out var parsedDate))
                    dateOfBirth = parsedDate;
                else
                    Console.WriteLine("You did not enter a valid date");
            }

            return dateOfBirth;
        }
    }
}
