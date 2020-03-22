using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(GetUserDateOfBirth("Rusty Malpass"));
            Console.WriteLine(GetUserDateOfBirth("Luke Malpass"));
        }

        public static string GetUserDateOfBirth(string fullName)
        {
            return fullName + " was born on Tuesday";
        }
    }
}
