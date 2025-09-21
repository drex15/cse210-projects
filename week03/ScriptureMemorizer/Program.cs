using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Scripture Memorizer");
            Console.Write("Would you like to continue (YES or NO)? ");
            string answer = Console.ReadLine();
            // added an if statement do prompt the user either to fun the memorizer or exit the code entirely 
            if (answer == "yes")
            {
                // Library of scriptures
                var scriptures = new List<Scripture>
                {
                    new Scripture(new Reference("John", 3, 16),
                    "For God so loved the world that he gave his one and only Son, " +
                    "that whoever believes in him shall not perish but have eternal life."),

                    new Scripture(new Reference("Proverbs", 3, 5, 6),
                    "Trust in the Lord with all your heart and lean not on your own understanding; " +
                    "in all your ways submit to him, and he will make your paths straight."),

                    new Scripture(new Reference("Philippians", 4, 13),
                    "I can do all things through Christ which strengtheneth me."),

                    new Scripture(new Reference("Psalm", 23, 1),
                    "The Lord is my shepherd; I shall not want."),

                    new Scripture(new Reference("Romans", 8, 28),
                    "And we know that in all things God works for the good of those who love him, " +
                    "who have been called according to his purpose."),

                    new Scripture(new Reference("Isaiah", 41, 10),
                    "Fear thou not; for I am with thee: be not dismayed; for I am thy God: " +
                    "I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."),

                    new Scripture(new Reference("Joshua", 1, 9),
                    "Have not I commanded thee? Be strong and of a good courage; be not afraid, " +
                    "neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest."),

                    new Scripture(new Reference("Matthew", 11, 28, 30),
                    "Come unto me, all ye that labour and are heavy laden, and I will give you rest. " +
                    "Take my yoke upon you, and learn of me; for I am meek and lowly in heart: " +
                    "and ye shall find rest unto your souls. For my yoke is easy, and my burden is light."),

                    new Scripture(new Reference("2 Timothy", 1, 7),
                    "For God hath not given us the spirit of fear; but of power, and of love, and of a sound mind."),

                    new Scripture(new Reference("Psalm", 46, 1),
                    "God is our refuge and strength, a very present help in trouble."),

                    new Scripture(new Reference("1 Corinthians", 10, 13),
                    "There hath no temptation taken you but such as is common to man: " +
                    "but God is faithful, who will not suffer you to be tempted above that ye are able; " +
                    "but will with the temptation also make a way to escape, that ye may be able to bear it."),

                    new Scripture(new Reference("Galatians", 5, 22, 23),
                    "But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, meekness, temperance: " +
                    "against such there is no law."),

                    new Scripture(new Reference("Ephesians", 6, 11),
                    "Put on the whole armour of God, that ye may be able to stand against the wiles of the devil."),

                    new Scripture(new Reference("Hebrews", 11, 1),
                    "Now faith is the substance of things hoped for, the evidence of things not seen."),

                    new Scripture(new Reference("James", 1, 5),
                    "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, " +
                    "and upbraideth not; and it shall be given him.")
                };

                // Randomly pick one scripture from the list
                Random rnd = new Random();
                Scripture scripture = scriptures[rnd.Next(scriptures.Count)];

                // Main loop
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());

                    if (scripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("All words hidden. Program ending.");
                        break;
                    }

                    Console.WriteLine("Press ENTER to hide more words or type 'quit' to exit.");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        break;

                    scripture.HideRandomWords(3); // Hide 3 random words each step
                }
            }
            // added a else statement
            else
            {
                Console.WriteLine("Okay, maybe next time! Goodbye.");
            }
        }
    }
}

