using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. " + "Clear your mind and focus on your breathing.";
    }

    protected override void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine("\nLet's begin your breathing exercise...");
        Thread.Sleep(1000);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            NumericSpinner(4);  // countdown for inhale

            Console.Write("Breathe out... ");
            NumericSpinner(4);  // countdown for exhale
        }

        Console.WriteLine("\nGreat job staying focused on your breathing!");
    }

    // Custom numeric countdown spinner for breathing
    private void NumericSpinner(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);  // 1-second interval between each number
        }
        Console.WriteLine(); // move to next line
    }
}
