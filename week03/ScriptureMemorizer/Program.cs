using System;
using System.Collections.Generic;

// EXCEEDING REQUIREMENTS: 
// 1. The program selects a random scripture from a library of multiple scriptures rather than hardcoding just one.
// 2. The HideRandomWords method in Scripture.cs only selects from words that are currently visible, 
//    ensuring the program doesn't waste turns trying to hide already hidden words.

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures to randomly choose from
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Alma", 37, 37), "Counsel with the Lord in all thy doings, and he will direct thee for good.")
        };

        // Select a random scripture from the library
        Random random = new Random();
        int index = random.Next(scriptureLibrary.Count);
        Scripture scripture = scriptureLibrary[index];

        string userInput = "";

        // Main program loop
        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                // Hide 3 words at a time
                scripture.HideRandomWords(3);
            }
        }

        // Final display when all words are hidden or user types quit
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}