
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: This program includes a library of three scriptures.
        // The user can choose which scripture to memorize.
        // The program hides three random words each time ENTER is pressed.

        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine();
        Console.WriteLine("Choose a scripture to memorize:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("3. Alma 37:6");
        Console.WriteLine();
        Console.Write("Enter your choice (1-3): ");

        string choice = Console.ReadLine();

        Reference reference;
        string text;

        if (choice == "1")
        {
            reference = new Reference("John", 3, 16);
            text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        }
        else if (choice == "2")
        {
            reference = new Reference("Proverbs", 3, 5, 6);
            text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        }
        else if (choice == "3")
        {
            reference = new Reference("Alma", 37, 6);
            text = "By small and simple things are great things brought to pass.";
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return;
        }

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}
