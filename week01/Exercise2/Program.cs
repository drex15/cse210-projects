using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade? ");
        string totalGrade = Console.ReadLine();
        int grade = int.Parse(totalGrade);
        if (grade >= 90)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is: D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("Your grade is: F");
        }

        int gradeSign = grade % 10;
    
        
        if (gradeSign >= 7)
        {
            Console.WriteLine("+");
        }
        else if (gradeSign < 3)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("");
        }
        Console.WriteLine($"Your grade is {grade}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("keep it up next time!");
        }
    }

}