using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //////////////////// Part 1 ////////////////////
        // Display the first 10 natural numbers
        Console.WriteLine("First 10 natural numbers:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        //////////////////// Part 2 ////////////////////
        // Display the cube of the numbers up to an integer
        Console.Write("\nInput number of terms: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"Number is: {i} and cube of the {i} is: {i * i * i}");
        }

        //////////////////// Part 3 ////////////////////
        // Display the multiplication table of a given integer
        Console.Write("\nInput the number (Table to be calculated): ");
        int tableNumber = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{tableNumber} X {i} = {tableNumber * i}");
        }

        //////////////////// Part 4 ////////////////////
        // Display an alphabet pattern like Y with an asterisk
        Console.WriteLine("\nAlphabet pattern like Y:");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if ((i == j && i < 4) || (i + j == 6 && i < 4) || (i >= 4 && j == 3))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        //////////////////// Part 5 ////////////////////
        // Simulate health regeneration over 5 rounds
        int health = 0;
        for (int round = 1; round <= 5; round++)
        {
            health += 10;
            Console.WriteLine($"Round {round}: Health {health}");
        }

        //////////////////// Part 6 ////////////////////
        // Create a list of names and iterate through them using foreach
        List<string> names = new List<string> { "John", "James", "Luke", "Lila" };
        Console.WriteLine("\nDisplaying names:");
        foreach (string name in names)
        {
            Console.WriteLine($"Name: {name}");
        }

        //////////////////// Part 7 ////////////////////
        // Create a list of numbers and display the square of each number using foreach
        List<int> numbers = new List<int> { 2, 3, 4, 5 };
        Console.WriteLine("\nDisplaying squares of numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine($"Square of {number}: {number * number}");
        }
    }
}
