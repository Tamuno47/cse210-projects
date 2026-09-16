using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random random;

    public string GetRandomPrompt()
    {
        int randomNumber = random.Next(0, 7);
        return _prompts[randomNumber];
    }

    public PromptGenerator()
    {
        _prompts = new List<string>();
        random = new Random();

        _prompts.Add("What is one thing you are grateful for today?");
        _prompts.Add("What was the most memorable moment of your day?");
        _prompts.Add("What is one lesson you learned today?");
        _prompts.Add("Who made a positive impact on your day today?");
        _prompts.Add("What is one thing you would like to improve tomorrow?");
        _prompts.Add("What made you smile today?");
        _prompts.Add("What is one goal you want to accomplish this week?");
    }
}