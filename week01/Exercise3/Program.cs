using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Pick a random magic number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Variable to store the user's guess
        int guess = -1;

        // 2. Loop until the guess matches the magic number
        do
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            // 3. Check the guess against the magic number
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != magicNumber);
    }
}