using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{
    private List<string> _prompts;
    
    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area"
        )
    {
        _prompts = new List<string>
        {
           "Who are people that you appreciate?",
           "What are personal strengths of yours?",
           "Who are people that you have helped this week?",
           "When have you felt the Holy Ghost this month?",
           "Who are some of your personal heroes?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    public void Run()
    {
        StartingMessage();

        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine();
        Console.WriteLine("Now take a moment to think about this....");
        ShowSpinner(5);
        Console.WriteLine();

        int count = 0;

        for (int i = 0; i < GetDuration(); i++)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            count++;
        }

    Console.WriteLine();
    Console.WriteLine($"You listed {count} items.");
    }

}