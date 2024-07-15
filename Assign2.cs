using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: Calculator <number1> <operation> <number2>");
                return;
            }

            double num1 = double.Parse(args[0]);
            char operation = char.Parse(args[1]);
            double num2 = double.Parse(args[2]);

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
                        Console.WriteLine("Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter '+', '-', '*', or '/'.");
                    return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
