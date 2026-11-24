
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");

            int remaining = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds);

            ShowCountDown(Math.Min(3, remaining));

            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Breathe out... ");

            remaining = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds);

            ShowCountDown(Math.Min(3, remaining));
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
