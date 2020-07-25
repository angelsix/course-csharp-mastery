using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Say hi
            Console.WriteLine("Welcome contestant!");

            // Create random number
            var numberToGuess = new Random().Next(101);

            // Create invalid guessed number
            var guess = -1;

            // While number is invalid...
            while (guess != numberToGuess)
            {
                // Ask user to guess a number between 0 and 100
                Console.WriteLine("Take a guess what I'm thinking... Any number between 0 and 100");

                // Read users input
                var input = Console.ReadLine();

                // If they are a cheater...
                if (input == "cheat")
                {
                    // Tell them the number
                    Console.WriteLine($"Shhhh... I'm thinking of {numberToGuess}");

                    // Done
                    continue;
                }

                // If they want to change the number to guess...
                if (input == "change")
                {
                    // Create a new random number
                    numberToGuess = new Random().Next(101);

                    // And as they know the secret command, tell them the new number
                    Console.WriteLine($"Shhhh... I'm now thinking of {numberToGuess}");

                    // Done
                    continue;
                }

                // If user entered a valid integer...
                if (int.TryParse(input, out guess))
                {
                    // If it matches the guess...
                    if (guess == numberToGuess)
                    {
                        // Congratulate them
                        Console.WriteLine($"Well done!!! You guessed right. I was thinking of {numberToGuess}");

                        // Exit loop
                        break;
                    }
                    // Otherwise...
                    else
                    {
                        // Let them know if the number was higher or lower
                        Console.WriteLine($"Not quite. I'm thinking of a number that is { (guess > numberToGuess ? "lower" : "higher") }");
                    }
                }
                // Otherwise...
                else
                {
                    // If parse failed, guess is set to 0. If the actual number was also 0
                    // we would get an invalid "sorry wrong" but while loop exits
                    // So reset it to -1
                    guess = -1;

                    // Ask them to enter a valid number
                    Console.WriteLine($"Sorry but that isn't a valid whole number.");
                }
            }

            // Say thanks for playing
            Console.WriteLine("Thanks for playing");

            // Pause so application does not instantly exit
            Console.ReadLine();
        }
    }
}
