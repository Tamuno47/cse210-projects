using System;

class Program
{
    static void Main(string[] args)
    {
        // Getting user grade percent
        Console.Write("What is your grade percent? ");
        string userGrade = Console.ReadLine();
        int number = int.Parse(userGrade);

        string letter = "";
        string sign = "";
        int lastDigit = number % 10;
        
        
        if (number >= 90)
        {
            letter = "A";
        }

        else if (number >= 80)
        {
            letter = "B";
        }

        else if (number >= 70)
        {
            letter = "C";
        }

        else if (number >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }


        if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }


        // Checking if grade is + or -
        if (number >= 93)
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        // Display the result 
        Console.WriteLine($"Your grade is: {letter}{sign}");


        if (number >= 70)
        {
            Console.WriteLine("You have successfully passed the course");
        }

        else
        {
            Console.WriteLine("You did not pass the course, try better next time");
        }


    }
}