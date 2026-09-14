using System;

/*
 * EXCEEDING REQUIREMENTS REPORT:
 * 1. Added a 'Mood Tracker' variable to every journal entry (e.g., Happy, Stressed, Inspired, Calm). 
 *    This helps users identify emotional trends in their writing over time.
 * 2. Integrated a Custom Delimiter ("~|~") pattern to safely handle responses containing commas, quotes, 
 *    or punctuation without corrupting file parsing.
 * 3. Added input validation and file existence error handling to prevent application crashes when reading files.
 */

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptGenerator promptGen = new PromptGenerator();
            bool running = true;

            Console.WriteLine("Welcome to the Journal Program!");

            while (running)
            {
                Console.WriteLine("\nPlease select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = promptGen.GetRandomPrompt();
                        Console.WriteLine($"\nPrompt: {prompt}");
                        Console.Write("> ");
                        string response = Console.ReadLine();

                        Console.Write("How are you feeling right now? (e.g., Happy, Peaceful, Tired): ");
                        string mood = Console.ReadLine();

                        string date = DateTime.Now.ToShortDateString();

                        Entry newEntry = new Entry(date, prompt, response, mood);
                        journal.AddEntry(newEntry);
                        break;

                    case "2":
                        journal.DisplayAll();
                        break;

                    case "3":
                        Console.Write("\nWhat is the filename to load? ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadFromFile(loadFilename);
                        break;

                    case "4":
                        Console.Write("\nWhat is the filename to save to? ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose a number from 1 to 5.");
                        break;
                }
            }
        }
    }
}