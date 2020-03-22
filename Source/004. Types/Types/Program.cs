using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Integral types
            sbyte mySByte;      // -128 to 127
            byte myByte;        // 0 to 255
            short myShort;      // -32,768 to 32,767
            ushort myUShort;    // 0 to 65,535
            int myInt;          // -2,147,483,648 to 2,147,483,647
            uint myUInt;        // 0 to 4,294,967,295
            long myLong;        // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong myULong;      // 0 to 18,446,744,073,709,551,615
            
            // -0000000, 00000001, 00000010, 00000011, 00000100, 00000101
            // 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2
            // 2 ^ 8
            // 256

            float myFloat; // Approximately 6-9 digits (32 bits / 4 bytes)
            double myDouble; // Approximately 15-17 digits (64 bits / 8 bytes)
            decimal myDecimal; // Approximately 28-29 digits (128 bits / 16 bytes)

            myFloat = 11111115111.05f;
            Console.WriteLine($"{myFloat:F10}");

            bool myBool;
            char myChar;
            string myString;

            Console.WriteLine($"A boolean is {sizeof(bool)} bytes");

            myBool = true;
            myBool = false;

            myChar = 'a';
            myString = "aaa";

            DateTime myDate;
            TimeSpan myTime;

            // Options for storing data
            //
            // 1. Whole numbers
            // 2. Floating point numbers
            // 3. Truth values
            // 4. Text (char/string)
            //
        }
    }
}
