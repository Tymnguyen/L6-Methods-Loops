using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------------------------------------------------------------------
        // Question 1: Finding the First Element Greater Than 50
        // Define an integer array
        int[] numbers1 = { 25, 45, 60, 30, 75, 10 };
        // Find the first element greater than 50
        int firstGreaterThan50 = Array.Find(numbers1, IsGreaterThan50);
        // Display the result
        Console.WriteLine("First element greater than 50: " + firstGreaterThan50);

        // ---------------------------------------------------------------------
        // Question 2: Find the First Element Greater Than 10
        // Define an integer array
        int[] numbers2 = { 5, 7, 12, 8, 15 };
        // Find the first element greater than 10
        int firstGreaterThan10 = Array.Find(numbers2, IsGreaterThan10);
        // Display the result
        Console.WriteLine("First element greater than 10: " + firstGreaterThan10);

        // ---------------------------------------------------------------------
        // Question 3: Find the First Negative Number
        // Define an integer array
        int[] numbers3 = { 3, -5, 8, -10, 12 };
        // Find the first negative number
        int firstNegative = Array.Find(numbers3, IsNegative);
        // Display the result
        Console.WriteLine("First negative number: " + firstNegative);
    }

    // Predicate function for Question 1: Check if the number is greater than 50
    static bool IsGreaterThan50(int num)
    {
        return num > 50;
    }

    // Predicate function for Question 2: Check if the number is greater than 10
    static bool IsGreaterThan10(int num)
    {
        return num > 10;
    }

    // Predicate function for Question 3: Check if the number is negative
    static bool IsNegative(int num)
    {
        return num < 0;
    }
}
