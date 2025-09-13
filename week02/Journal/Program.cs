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
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("what would you like to choose? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
