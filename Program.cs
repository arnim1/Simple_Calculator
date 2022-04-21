using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class SimpleCalculator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;
                try
                {
                    Console.WriteLine("Enter the first number");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second number");
                    secondValue = double.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.Write("Could not convert string to number!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Select operation: '+' '-' '*' '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine("You cannot divide by '0' ");
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }
                        break;
                    default:
                        Console.WriteLine("Eror! Unknow operation");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
