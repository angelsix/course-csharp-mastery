using System;

using System.Globalization;

namespace BirthDayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduce our Savvy robot
            IntroduceSavvy();

            // Ask the user for their date of birth
            var usersDateOfBirth = AskForDateOfBirth();
        }

        /// <summary>
        /// Introduce Savvy the robot to our user
        /// </summary>
        public static void IntroduceSavvy()
        {
            // Output message to user
            Console.WriteLine("Hi, I'm Savvy. " +
                "I'm really good at guessing the " +
                "day of the week you were born on.");
        }

        /// <summary>
        /// Ask the user for their date of birth, until it is given in a correct format.
        /// </summary>
        /// <remarks>
        /// This call will not return until a valid date is entered or the application 
        /// is terminated.
        /// </remarks>
        /// <returns>The date of birth the user entered</returns>
        public static DateTimeOffset AskForDateOfBirth()
        {
            // Create checked date with initial out of range value
            var dateOfBirth = DateTimeOffset.MaxValue;

            // Until the checked date is greater than today...
            while (dateOfBirth > DateTimeOffset.UtcNow)
            {
                // Tell the user to enter their date of birth
                Console.WriteLine($"Can I start by asking you " +
                             $"what your date of birth is? { CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern }");

                // Read their response
                var userText = Console.ReadLine();

                // If the user entered a valid date...
                if (DateTimeOffset.TryParse(userText, out var parsedDate))
                    // Set the checked date to users given date
                    dateOfBirth = parsedDate;
                // Otherwise...
                else
                    // Inform user they entered invalid date
                    Console.WriteLine("You did not enter a valid date");
            }

            // Return the result
            return dateOfBirth;
        }
    }
}
