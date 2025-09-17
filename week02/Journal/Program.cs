using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("------------------------------------------");
            Console.Write("what would you like to choose? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();
                journal.AddEntry(prompt, response);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }

            else if (choice == "4")
            {
                Console.Write("Enter  the filename to be loaded : ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
                journal.DisplayEntries();
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("I'm afraid your option is invalid. Try another option.");
            }
        }
    }
}
