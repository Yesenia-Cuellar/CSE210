
using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectingActivity()
        : base(
            "Reflecting",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _random = new Random();

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");

        DisplayPrompt();

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press ENTER to continue.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine();
        Console.WriteLine("Now reflect on each of these questions:");

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();

            if (DateTime.Now < endTime)
            {
                Console.WriteLine();
                Console.WriteLine("Take your time to think...");
                ShowSpinner(3);
            }
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "Think about a time when you helped someone.";
        }

        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];

        // Creativity: prompts are not repeated until the list is used.
        _prompts.RemoveAt(index);

        return prompt;
    }

    public string GetRandomQuestion()
    {
        if (_questions.Count == 0)
        {
            return "What did you learn from this experience?";
        }

        int index = _random.Next(_questions.Count);
        string question = _questions[index];

        // Creativity: questions are not repeated until the list is used.
        _questions.RemoveAt(index);

        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine();
        Console.WriteLine(GetRandomQuestion());

        ShowSpinner(5);
    }
}
