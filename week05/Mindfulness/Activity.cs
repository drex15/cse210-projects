using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void StartActivity()
    {
        DisplayStartingMessage();
        RunActivity();
        DisplayEndingMessage();

        // Log activity completion
        ActivityLog.AddEntry(_name, _duration);
    }

    protected virtual void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"=== {_name} === \n");
        ShowSpinner(3);
        Console.WriteLine($"{_description}\n");

        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    protected virtual void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job!");
        ShowSpinner(2);
        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    // Spinner animation
    public static void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            index = (index + 1) % spinner.Length;
        }
        Console.WriteLine();
    }

    protected abstract void RunActivity();
}
