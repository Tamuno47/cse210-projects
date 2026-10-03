using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetName()
    {
       return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void StartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Starting {GetName()}");
        Console.WriteLine();
        Console.WriteLine(GetDescription());
        Console.WriteLine();

        SetDuration();

        Console.WriteLine();
        Console.WriteLine("Get Ready...");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void EndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");

        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()}.");

        ShowSpinner(3);
        Console.WriteLine();
    }

}