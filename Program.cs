using System;

namespace ConsoleCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {

                char operation = ' ';
                double num1 = 0, num2 = 0;
                string result;
                bool is_continue = true;

                Console.Clear();
                Console.WriteLine("Hello, user! It calculator");

                while (is_continue)
                {
                    Console.Write("Please, select operation (+, -, *, /, ^): ");
                    operation = Console.ReadLine()[0];

                    if (operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '^')
                        is_continue = false;
                    else
                        Console.WriteLine("Oops! Operation type is wrong!");
                }

                is_continue = true;
                while (is_continue)
                {
                    Console.Write("Okay, enter the first number: ");
                    try
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        is_continue = false;
                    }
                    catch
                    {
                        Console.WriteLine("Oops! Number is wrong!");
                    }
                }

                is_continue = true;
                while (is_continue)
                {
                    Console.Write("And last, enter the second number: ");
                    try
                    {
                        num2 = Convert.ToDouble(Console.ReadLine());
                        is_continue = false;
                    }
                    catch
                    {
                        Console.WriteLine("Oops! Number is wrong!");
                    }
                }

                switch (operation)
                {
                    case '+':
                        result = (num1 + num2).ToString();
                        break;
                    case '-':
                        result = (num1 - num2).ToString();
                        break;
                    case '*':
                        result = (num1 * num2).ToString();
                        break;
                    case '/':
                        result = (num1 / num2).ToString();
                        break;
                    case '^':
                        result = (Math.Pow(num1, num2)).ToString();
                        break;
                    default:
                        Console.WriteLine("Oops! Something went wrong!");
                        return;
                }

                Console.WriteLine("Done! Result is " + result);

                Console.WriteLine("\nExit? (n,y)");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "yes")
                    return;
            }
        }
    }
}
