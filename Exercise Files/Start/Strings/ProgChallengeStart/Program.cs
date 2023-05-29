using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            bool keepGoing = true;
            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int guessNum = 0;
            int userNumCount = 0;

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            do {
                Console.WriteLine("What's your guess?");
                string theGuess = Console.ReadLine();

                // Use the TryParse method to parse the input into a number
                bool result = Int32.TryParse(theGuess, out guessNum);

                // If the user entered something other than a number ask them to try again
                if (!result) {
                    Console.WriteLine("Hmm, that doesn't look like a number. Please input a number.");
                }
                else {
                    // If they enter a -1 then they want to exit the game
                    if (guessNum == -1) {
                        Console.WriteLine($"Oh, so you quit? I was thinking of {theNumber}...better luck next time.");
                        keepGoing = false;
                    }
                    else {
                        // Increase the guess count by 1
                        userNumCount++;

                        // If the user got it right, tell them the guess count and exit
                        if (guessNum == theNumber) {
                            Console.WriteLine($"You got it in {userNumCount} guesses!");
                            keepGoing = false;
                        }
                        else {
                            // Tell the user to guess lower or higher than the previous guess
                            Console.WriteLine("Nope, {0} than that.", guessNum < theNumber ? "higher" : "lower");
                        }
                    }
                }
            } while (keepGoing);
        }
    }
}
