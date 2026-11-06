using System;
using System.Collections.Generic;
public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "How did you feel today?",
        "What made you feel peaceful today?",
        "What was something that worried you today?",
        "What helps you feel happy?",
        "What are you grateful for today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}