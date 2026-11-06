using System;

class Program
{
    static void Main(string[] args)
    {
        // Creative feature: The program allows users to count
        // how many entries are stored in their journal.
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Count Journal Entries");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string answer = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = answer;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the file name: ");
                string file = Console.ReadLine();

                if (System.IO.File.Exists(file))
                {
                    journal.LoadFromFile(file);
                    Console.WriteLine("Journal loaded successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            else if (choice == "4")
            {
                Console.Write("Enter the file name: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == "5")
            {
                int count = journal.GetEntryCount();
                Console.WriteLine($"You have {count} entries in your journal.");
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
