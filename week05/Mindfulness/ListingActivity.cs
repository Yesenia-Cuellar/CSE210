
using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random;

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _random = new Random();

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");

        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine();
        Console.WriteLine("You may begin in:");

        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing:");

        List<string> answers = new List<string>();
        string currentAnswer = "";

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    if (!string.IsNullOrWhiteSpace(currentAnswer))
                    {
                        answers.Add(currentAnswer.Trim());
                    }

                    currentAnswer = "";
                    Console.WriteLine();
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (currentAnswer.Length > 0)
                    {
                        currentAnswer = currentAnswer.Substring(
                            0, currentAnswer.Length - 1);

                        Console.Write("\b \b");
                    }
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    currentAnswer += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }
            else
            {
                Thread.Sleep(50);
            }
        }

        if (!string.IsNullOrWhiteSpace(currentAnswer))
        {
            answers.Add(currentAnswer.Trim());
        }

        _count = answers.Count;

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];

        // Creativity: remove used prompts to avoid immediate repetition.
        _prompts.RemoveAt(index);

        return prompt;
    }
}
