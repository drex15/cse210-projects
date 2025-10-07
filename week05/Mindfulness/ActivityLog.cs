using System;
using System.IO;

public static class ActivityLog
{
    private static string _filePath = "activity_log.txt";

    public static void AddEntry(string activityName, int duration)
    {
        string entry = $"{DateTime.Now:G} | {activityName} | Duration: {duration} seconds";
        File.AppendAllText(_filePath, entry + Environment.NewLine);
        Console.WriteLine("\nActivity logged successfully!");
    }

    public static void DisplayLog()
    {
        Console.Clear();
        Console.WriteLine("=== Activity Log ===\n");

        if (!File.Exists(_filePath) || new FileInfo(_filePath).Length == 0)
        {
            Console.WriteLine("No activities logged yet.");
            return;
        }

        string[] logEntries = File.ReadAllLines(_filePath);
        foreach (string line in logEntries)
        {
            Console.WriteLine(line);
        }
    }
}
