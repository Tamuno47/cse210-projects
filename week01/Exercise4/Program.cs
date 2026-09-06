using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            // Add the numbers to the List but not 0
           if (userNumber != 0)
            {
                numbers.Add(userNumber);
            } 


        }

        // CR 1: Compute the sum of the numbers in the list.

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // CR 2: Compute the average of the numbers in the list.

        // To get the average, we must divide the sum by the
        // by the number of items in the List.
        
        // But first, we must convert sum temporarily to a 
        // float so C# will give us a floating point division
        // and arrive at a decimal point answer instead of
        // giving us a whole number.

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        // CR 3: Find the maximum number in the list.
        
        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                // We start checking with the first number
                // as the maximum and check if any other
                // number is greater.

                maximum = number;
            }
        }

        Console.WriteLine($"The maximum number is: {maximum}");

    }
}