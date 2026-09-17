using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        string choice = "";

        do
        {
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Show the number of entries");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts.GetRandomPrompt();

                Console.WriteLine(prompt);

                Console.Write("Your response: ");
                string entryText = Console.ReadLine();

                string date = DateTime.Now.ToString("yyyy-MM-dd");

                Entry newEntry = new Entry(date, prompt, entryText);

                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }
    
        }
        while (choice != "5");
    }
}