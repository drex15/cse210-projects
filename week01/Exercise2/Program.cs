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
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("F");
        }

        int gradeSign = grade % 10;
    
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