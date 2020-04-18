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

            var someString = "Some string";
            var someString2 = "Some " + "string";
            var someString3 = 4.ToString();
            var someString4 = $"I earned { 400 } today";

            var todaysDate = DateTimeOffset.UtcNow;
            var todaysWeather = SomeWeatherProvider.GetWeatherToday();
            var rainfall = RainfallData.HeightInInches;

            var someString5 = $"Today is { todaysDate }" +
                $" and the weather outside is { todaysWeather }" +  
                $". The rainfall is expected to be { rainfall } inches.";

            //var someInvalidString = $"{ Console.WriteLine() }";

            var someResult = 1 * 4;
            var someString6 = $"{ someResult }";

            var userText = Console.ReadLine();

            return DateTimeOffset.Parse(userText);
        }
    }








    public class SomeWeatherProvider
    {
        public static object GetWeatherToday()
        {
            return new object();
        }
    }

    public class RainfallData
    {
        public static float HeightInInches { get; set; }
    }
}
