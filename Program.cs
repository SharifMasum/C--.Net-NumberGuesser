// See https://aka.ms/new-console-template for more information

using System;

// Namespace
namespace NumberGuessser
{
    // Main class
    class Progress
    {
        // Entry point method
        static void Main(string[] args)
        {
            // Run getAppInfo to get app info
            getAppInfo();

            //Greeting
            GreetUser();

            while (true)
            {
                // Init correct number
                // int correctNumber = 5;

                // Create a new Random object
                Random random = new Random();


                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess variable
                int guess = 0;

                // Ask user for number entry
                Console.WriteLine("Guess a number between 1 and 10");

                // When guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure input is number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please insert an actual number");

                        // keep continue
                        continue;
                    }

                    // Cast to int and put guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number! Please try again");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT! You guessed it right!");

                // Ask to play again
                Console.WriteLine("Play again [Y or N]");

                // Get the answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        // Get and display app info
        static void getAppInfo()
        {
            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Md Shariful Islam";

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // App info
            Console.WriteLine("{0}: Version {1} by {2}",
                appName, appVersion, appAuthor);

            // Reset text colour
            Console.ResetColor();
        }

        // Ask user name and greet
        static void GreetUser()
        {
            //Ask user name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine(
                "Hello {0}, let's play a game....", inputName);
        }

        // Print colour message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text colour
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset colour
            Console.ResetColor();
        }
    }
            
            
}
