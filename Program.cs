using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jacob Broughton";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1}. Created by {2}", appName, appVersion, appAuthor);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello, {0}. Lets play a game.", inputName);

            // Init correct number
            Random random = new Random();
            int correctNumber = random.Next(1, 11);
            Console.WriteLine(correctNumber);

            // Init guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");
        
            while (guess != correctNumber)
            {
                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out guess);
                
                if(isNumber)
                {
                    guess = Int32.Parse(input);

                    if (guess != correctNumber) {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, please try again.");
                        Console.ResetColor();

                    } else {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Great job, you guessed it!");
                        Console.ResetColor();
                    }
                    } else {

                        Console.WriteLine("Try again bucko");
        
                }
            }
        }
    }
}
