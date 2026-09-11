using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Call the function to display the welcome message
        DisplayWelcomeMessage();

        // 2. Call the function to get the user's name and save it in a variable
        string userName = PromptUserName();

        // 3. Call the function to get the user's number and save it in a variable
        int userNumber = PromptUserNumber();

        // 4. Call the function to square the number and save the result
        int squaredNumber = SquareNumber(userNumber);

        // 5. Call the function to display the final result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display the welcome message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt for and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to prompt for and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    // Function to square a number
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // Function to display the final output using the name and the squared number
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}