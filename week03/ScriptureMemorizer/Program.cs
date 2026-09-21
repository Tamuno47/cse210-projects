using System;

class Program
{
    static void Main(string[] args)
    {
        // To show creativity I've added a small scripture library that allows the user
        // to choose which scripture they want to memorize.

        Console.WriteLine("Scripture Memorizer");
        Console.WriteLine();
        Console.WriteLine("Choose a scripture:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        Reference reference;
        string text;

        if (choice == "2")
        {
            reference = new Reference("Proverbs", 3, 5, 6);

            text = "Trust in the Lord with all thine heart; and lean not unto " +
                   "thine own understanding. In all thy ways acknowledge him, " +
                   "and he shall direct thy paths.";
        }
        else
        {
            reference = new Reference("John", 3, 16);

            text = "For God so loved the world that he gave his only begotten Son";
        }

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}