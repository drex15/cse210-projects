using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name? ");
        String firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        String lastname = Console.ReadLine();
        
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}
