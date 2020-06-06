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

            // Announce information about date
            AnnouceDateOfBirthInformation(usersDateOfBirth);
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

        /// <summary>
        /// Display information to the user about the given date of birth
        /// </summary>
        /// <param name="date">The date of birth to display information about</param>
        public static void AnnouceDateOfBirthInformation(DateTimeOffset date)
        {
            // Store current time
            var now = DateTimeOffset.UtcNow;

            // Display date of birth
            Console.WriteLine($"So you were born on {date:d MMMM yyyy}");

            // Display day of the week they were born
            Console.WriteLine($"That was a {date.DayOfWeek}");

            // Indicate if we have already passed the users date of birth
            // for the current year
            var hasPassedBirthday = now.DayOfYear > date.DayOfYear;

            // Get a date representing the users next birthday
            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0), date.Month, date.Day, 0, 0, 0, TimeSpan.Zero);

            // Display how many days until the next birthday
            Console.WriteLine($"It is {(nextBirthday - now).TotalDays:0} days until your next birthday");

            // Get the users age
            var userAge = now.Year - date.Year - (hasPassedBirthday ? 0 : 1);

            // Display users age
            Console.WriteLine($"You are {userAge} years old");

            // Display users age in dog years
            Console.WriteLine($"You are {userAge * 7} in dog years");

            // Get users time alive
            var timeAlive = now - date;

            // Display days old
            Console.WriteLine($"You are {timeAlive.TotalDays:n0} days old");

            // Display hours old
            Console.WriteLine($"You are {timeAlive.TotalHours:n0} hours old");

            // Display seconds old
            Console.WriteLine($"You are {timeAlive.TotalSeconds:n0} seconds old");
        }
    }
}
