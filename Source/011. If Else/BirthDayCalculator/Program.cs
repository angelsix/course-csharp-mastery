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
            Console.WriteLine($"Can I start by asking you " +
                $"what your date of birth is? { CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern }");

            var userText = Console.ReadLine();

            var parsedDate = DateTimeOffset.MinValue;

            var succeeded = DateTimeOffset.TryParse(userText, out parsedDate);

            if (succeeded)
            {
                return parsedDate;
            }
            else
            {
                Console.WriteLine("You did not enter a valid date");

                return AskForDateOfBirth();
            }
        }
    }
}














