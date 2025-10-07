using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity helps you reflect on times when you have shown strength and resilience.";
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("Take a few seconds to think about it...");
        ShowSpinner(4);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine("\nAs you reflect, you can type your thoughts. Press [Enter] to submit them.");
        Console.WriteLine("(If you don't type anything, the spinner will continue.)\n");

        List<string> userResponses = new List<string>();

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine($"\n{question}");

            // Start the spinner in a separate thread
            bool spinnerRunning = true;
            Thread spinnerThread = new Thread(() =>
            {
                string[] spinner = { "|", "/", "-", "\\" };
                int index = 0;
                while (spinnerRunning)
                {
                    Console.Write(spinner[index]);
                    Thread.Sleep(150);
                    Console.Write("\b \b");
                    index = (index + 1) % spinner.Length;
                }
            });

            spinnerThread.Start();

            DateTime questionEnd = DateTime.Now.AddSeconds(6); // each question runs for 6s
            string input = "";

            // Allow user to type input while spinner continues
            while (DateTime.Now < questionEnd)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(intercept: true);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (!string.IsNullOrWhiteSpace(input))
                        {
                            userResponses.Add(input.Trim());
                            Console.WriteLine($"\n✔ Recorded: {input}");
                            input = "";
                        }
                    }
                    else
                    {
                        Console.Write(key.KeyChar);
                        input += key.KeyChar;
                    }
                }
                Thread.Sleep(50);
            }

            // Stop the spinner for this question
            spinnerRunning = false;
            spinnerThread.Join();
        }

        // Display summary of user input
        Console.WriteLine("\nReflection session completed!");
        if (userResponses.Count > 0)
        {
            Console.WriteLine("\nHere’s what you reflected on:");
            foreach (var r in userResponses)
                Console.WriteLine($"- {r}");
        }
        else
        {
            Console.WriteLine("\nNo responses recorded — that’s okay! Reflection can also be silent. 🌿");
        }
    }
}
