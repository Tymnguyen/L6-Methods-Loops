using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Displaying a Welcome Message
        DisplayWelcomeMessage();

        // Part 2: Personalized Welcome Message
        PersonalizedWelcomeMessage("Alice");

        // Part 3: Calculating the Sum of Two Numbers
        int sum = CalculateSum(5, 10);
        Console.WriteLine("Sum: " + sum);

        // Part 4: Counting Spaces in a String
        int spaceCount = CountSpaces("Hello World! How are you?");
        Console.WriteLine("Number of spaces: " + spaceCount);

        // Part 5: Calculating the Sum of Elements in an Array
        int[] numbers = { 1, 2, 3, 4, 5 };
        int arraySum = CalculateArraySum(numbers);
        Console.WriteLine("Array sum: " + arraySum);

        // Part 6: Swapping Two Integer Numbers
        int a = 5, b = 10;
        SwapNumbers(ref a, ref b);
        Console.WriteLine("After swap, a: " + a + ", b: " + b);

        // Part 7: Calculating Exponentiation
        CalculateExponent(2, 3);

        // Part 8: Displaying the Fibonacci Sequence
        DisplayFibonacciSequence(10);

        // Part 9: Checking Prime Numbers
        CheckPrimeNumber(29);

        // Part 10: Calculating the Sum of Individual Digits
        CalculateDigitSum(12345);

        // Part 11: Testing Named Parameters in C#
        DisplayInfo(name: "John", age: 30);

        // Part 12: Testing Out Parameters in C#
        GetSquareRoot(16, out double squareRoot);
        Console.WriteLine("Square Root: " + squareRoot);

        // Part 13: Testing Default or Optional Parameters in C#
        GreetUser("Emily");
        GreetUser("Bob", "Good morning");
    }

    // Part 1: Displaying a Welcome Message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to our application!");
    }

    // Part 2: Personalized Welcome Message
    static void PersonalizedWelcomeMessage(string name)
    {
        Console.WriteLine("Welcome, " + name + "!");
    }

    // Part 3: Calculating the Sum of Two Numbers
    static int CalculateSum(int num1, int num2)
    {
        return num1 + num2;
    }

    // Part 4: Counting Spaces in a String
    static int CountSpaces(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == ' ') count++;
        }
        return count;
    }

    // Part 5: Calculating the Sum of Elements in an Array
    static int CalculateArraySum(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    // Part 6: Swapping Two Integer Numbers
    static void SwapNumbers(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    // Part 7: Calculating Exponentiation
    static void CalculateExponent(int baseNum, int exponent)
    {
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }
        Console.WriteLine($"{baseNum} raised to the power of {exponent} is {result}");
    }

    // Part 8: Displaying the Fibonacci Sequence
    static void DisplayFibonacciSequence(int terms)
    {
        int first = 0, second = 1, next;
        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < terms; i++)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }
        Console.WriteLine();
    }

    // Part 9: Checking Prime Numbers
    static void CheckPrimeNumber(int number)
    {
        bool isPrime = true;
        if (number < 2) isPrime = false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            Console.WriteLine(number + " is a prime number.");
        else
            Console.WriteLine(number + " is not a prime number.");
    }

    // Part 10: Calculating the Sum of Individual Digits
    static void CalculateDigitSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine("Sum of digits: " + sum);
    }

    // Part 11: Testing Named Parameters in C#
    static void DisplayInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    // Part 12: Testing Out Parameters in C#
    static void GetSquareRoot(int number, out double result)
    {
        result = Math.Sqrt(number);
    }

    // Part 13: Testing Default or Optional Parameters in C#
    static void GreetUser(string name, string greetingMessage = "Hello")
    {
        Console.WriteLine($"{greetingMessage}, {name}!");
    }
}
