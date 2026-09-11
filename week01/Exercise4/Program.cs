using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new list to store integers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        // Loop to gather numbers until user enters 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            // Only add the number to the list if it is NOT 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average
        // Note: (float) ensures we do decimal division instead of integer division
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the maximum number
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // We found a new maximum!
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}