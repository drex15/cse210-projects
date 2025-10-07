using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness App ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Quit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    ActivityLog.DisplayLog();
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    continue;
                case "5":
                    quit = true;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    continue;
            }

            // Spinner when user selects an activity
            Console.WriteLine("\nLoading your activity...");
            Activity.ShowSpinner(3);

            activity.StartActivity();
        }

        Console.WriteLine("\nThanks for using the Mindfulness App. 🌿");
    }
}
