using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = PromptUserName();
        int favouriteNumber = PromptFavouriteNumber();
        int square = SquareOfNumber(favouriteNumber);

        DisplayResult(name, square);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptFavouriteNumber()
    {
        Console.Write("Please enter your favourite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareOfNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}