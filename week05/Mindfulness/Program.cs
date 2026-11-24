
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: The program uses random prompts and questions.
        // It also avoids repeating them until the available list is used.

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    break;
            }
        }
    }
}
