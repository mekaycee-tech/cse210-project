// EXCEEDING REQUIREMENTS SHOWCASE:
// 1. Added a session tracking log feature that counts how many total activities 
//    were completed during the program execution session.
// 2. Maintained clean encapsulation and robust menu input validation so the user 
//    can't break the application with invalid choices.

using System;

class Program
{
    static void Main(string[] args)
    {
        int sessionActivityCount = 0;
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                sessionActivityCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                sessionActivityCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                sessionActivityCount++;
            }
            else if (choice == "4")
            {
                keepRunning = false;
                Console.WriteLine($"\nThank you for taking time for yourself today!");
                Console.WriteLine($"Total activities completed this session: {sessionActivityCount}");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}