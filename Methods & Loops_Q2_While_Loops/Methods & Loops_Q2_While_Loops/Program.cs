using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////// Part 1 ////////////////////

        // Print numbers from 1 to 10 using a while loop
        int num1 = 1;
        while (num1 <= 10)
        {
            Console.WriteLine(num1);
            num1++;
        }

        //////////////////// Part 2 ////////////////////

        // Print numbers from 10 to 1 using a while loop
        int num2 = 10;
        while (num2 >= 1)
        {
            Console.WriteLine(num2);
            num2--;
        }

        //////////////////// Part 3 ////////////////////

        // Print even numbers from 1 to 10 using a while loop
        int num3 = 1;
        while (num3 <= 10)
        {
            if (num3 % 2 == 0)
            {
                Console.WriteLine(num3);
            }
            num3++;
        }

        //////////////////// Part 4 ////////////////////

        // Print odd numbers from 1 to 10 using a while loop
        int num4 = 1;
        while (num4 <= 10)
        {
            if (num4 % 2 != 0)
            {
                Console.WriteLine(num4);
            }
            num4++;
        }

        //////////////////// Part 5 ////////////////////

        // Print multiplication table of a number using while loop
        Console.Write("\nEnter a number to print its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int multiplier = 0;
        while (multiplier <= 10)
        {
            Console.WriteLine($"{number} * {multiplier} = {number * multiplier}");
            multiplier++;
        }

        //////////////////// Part 6 ////////////////////

        // Calculate the factorial of a number using while loop
        Console.Write("\nEnter a number to calculate its factorial: ");
        int factNum = Convert.ToInt32(Console.ReadLine());
        int factorial = 1, factCounter = factNum;
        while (factCounter > 0)
        {
            factorial *= factCounter;
            factCounter--;
        }
        Console.WriteLine($"The factorial of {factNum} is: {factorial}");

        //////////////////// Part 7 ////////////////////

        // Sum of series 1+2+3+...+n using while loop
        Console.Write("\nEnter a number to calculate the sum of the series: ");
        int seriesNum = Convert.ToInt32(Console.ReadLine());
        int sum = 0, seriesCounter = 1;
        while (seriesCounter <= seriesNum)
        {
            sum += seriesCounter;
            seriesCounter++;
        }
        Console.WriteLine($"The sum of series 1 to {seriesNum} is: {sum}");

        //////////////////// Part 8 ////////////////////

        // Print multiplication tables horizontally from 1 to n
        Console.Write("\nEnter a number to print its horizontal multiplication table: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Multiplication table from 1 to {n}");
        int row = 1;
        while (row <= 10)
        {
            int col = 1;
            while (col <= n)
            {
                Console.Write($"{col}x{row} = {col * row}\t");
                col++;
            }
            Console.WriteLine();
            row++;
        }

        //////////////////// Part 9 ////////////////////

        // Display right angle triangle pattern with numbers
        Console.Write("\nEnter the number of rows for the triangle: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i <= rows)
        {
            int j = 1;
            while (j <= i)
            {
                Console.Write(j);
                j++;
            }
            Console.WriteLine();
            i++;
        }

        //////////////////// Part 10 ////////////////////

        // Display right angle triangle using asterisks
        Console.Write("\nEnter the number of rows for the asterisk triangle: ");
        int astRows = Convert.ToInt32(Console.ReadLine());
        int k = 1;
        while (k <= astRows)
        {
            int l = 1;
            while (l <= k)
            {
                Console.Write("*");
                l++;
            }
            Console.WriteLine();
            k++;
        }

        //////////////////// Part 11 ////////////////////

        // Display pyramid pattern with numbers increasing by 1
        Console.Write("\nEnter the number of rows for the pyramid: ");
        int pyramidRows = Convert.ToInt32(Console.ReadLine());
        int num = 1;
        int m = 1;
        while (m <= pyramidRows)
        {
            // Print spaces
            int spaces = pyramidRows - m;
            while (spaces > 0)
            {
                Console.Write(" ");
                spaces--;
            }

            // Print numbers
            int p = 1;
            while (p <= m)
            {
                Console.Write(num + " ");
                num++;
                p++;
            }
            Console.WriteLine();
            m++;
        }

        //////////////////// Do While Loop ////////////////////

        // Example: while loop (condition is checked before the loop body runs)
        int x = 1;
        while (x < 1)
        {
            Console.WriteLine(x);
            x++;
        }

        // Example: do-while loop (loop body runs at least once before checking the condition)
        int y = 1;
        do
        {
            Console.WriteLine(y);
            y++;
        } while (y < 1);
    }
}
