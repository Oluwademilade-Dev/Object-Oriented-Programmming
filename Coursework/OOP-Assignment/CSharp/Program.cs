
using System;

namespace CSharpLearning;

class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("       PROGRAMMING BASICS");
            Console.WriteLine("================================");
            Console.WriteLine("1. Arithmetic Calculator");
            Console.WriteLine("2. Temperature Converter");
            Console.WriteLine("3. GPA Calculator");
            Console.WriteLine("4. Exit");
            Console.WriteLine("================================");

            Console.Write("Select an option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    ArithmeticCalculator();
                    break;

                case 2:
                    TemperatureConverter();
                    break;

                case 3:
                    GPACalculator();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the application!");
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please choose between 1 and 4.");
                    break;
            }

        } while (choice != 4);
    }

    static void ArithmeticCalculator()
    {
        Console.WriteLine("\n=== Arithmetic Calculator ===");

        Console.Write("Enter the first number: ");
        if (!double.TryParse(Console.ReadLine(), out double numberOne))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        Console.Write("Enter the second number: ");
        if (!double.TryParse(Console.ReadLine(), out double numberTwo))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        Console.Write("Enter operand (+, -, *, /): ");
        string? operand = Console.ReadLine();

        if (operand == "+")
        {
            Console.WriteLine($"Result: {numberOne + numberTwo:F2}");
        }
        else if (operand == "-")
        {
            Console.WriteLine($"Result: {numberOne - numberTwo:F2}");
        }
        else if (operand == "*")
        {
            Console.WriteLine($"Result: {numberOne * numberTwo:F2}");
        }
        else if (operand == "/")
        {
            if (numberTwo == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            else
            {
                Console.WriteLine($"Result: {numberOne / numberTwo:F2}");
            }
        }
        else
        {
            Console.WriteLine("Invalid operand. Please use +, -, * or /.");
        }
    }

    static void TemperatureConverter()
    {
        Console.WriteLine("\n=== Temperature Converter ===");
        Console.WriteLine("C - Celsius to Fahrenheit");
        Console.WriteLine("F - Fahrenheit to Celsius");

        Console.Write("Select conversion direction: ");
        string? unit = Console.ReadLine();

        if (unit == "C" || unit == "c")
        {
            Console.Write("Enter temperature in Celsius: ");

            if (!double.TryParse(Console.ReadLine(), out double celsius))
            {
                Console.WriteLine("Invalid input. Please enter a numerical temperature.");
                return;
            }

            if (celsius < -273.15)
            {
                Console.WriteLine("Invalid temperature. Below absolute zero.");
                return;
            }

            double fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2} °F");
        }
        else if (unit == "F" || unit == "f")
        {
            Console.Write("Enter temperature in Fahrenheit: ");

            if (!double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                Console.WriteLine("Invalid input. Please enter a numerical temperature.");
                return;
            }

            if (fahrenheit < -459.67)
            {
                Console.WriteLine("Invalid temperature. Below absolute zero.");
                return;
            }

            double celsius = (fahrenheit - 32) / 1.8;

            Console.WriteLine($"Temperature in Celsius: {celsius:F2} °C");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please choose C or F.");
        }
    }

    static void GPACalculator()
    {
        Console.WriteLine("\n=== GPA Calculator ===");

        Console.Write("Enter the number of courses: ");

        if (!int.TryParse(Console.ReadLine(), out int numberOfCourses) || numberOfCourses <= 0)
        {
            Console.WriteLine("Invalid number of courses.");
            return;
        }

        double sum = 0;

        for (int i = 1; i <= numberOfCourses; i++)
        {
            Console.Write($"Enter score for course {i} (1-6): ");

            if (!double.TryParse(Console.ReadLine(), out double score))
            {
                Console.WriteLine("Invalid input. Please enter a numerical score.");
                i--;
                continue;
            }

            if (score < 1 || score > 6)
            {
                Console.WriteLine("Invalid score. Please enter a score between 1 and 6.");
                i--;
                continue;
            }

            sum += score;
        }

        double average = sum / numberOfCourses;

        Console.WriteLine("\n=== GPA Results ===");
        Console.WriteLine($"Total courses: {numberOfCourses}");
        Console.WriteLine($"Total score: {sum:F2}");
        Console.WriteLine($"Average: {average:F2}");

        if (average >= 3.0)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed.");
        }
    }
}
