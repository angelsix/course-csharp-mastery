using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double a = 1;
            double b = 0;

            double result = a / b;

            string resultString = result.ToString();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(resultString);
        }
    }
}
