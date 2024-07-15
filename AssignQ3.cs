using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                Console.WriteLine("Welcome to the Four-Function Calculator!");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        PerformOperation('+');
                        break;
                    case '2':
                        PerformOperation('-');
                        break;
                    case '3':
                        PerformOperation('*');
                        break;
                    case '4':
                        PerformOperation('/');
                        break;
                    case '5':
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a number from 1 to 5.");
                        break;
                }

                Console.WriteLine();
            } while (choice != '5');
        }

        static void PerformOperation(char operation)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        return;
                    }
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
    }

