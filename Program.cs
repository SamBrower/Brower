// Written by Sam Brower
// 03/20/2023

// 100 lines code to make a calculator for a school project

using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CalculatorApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to close the calculator");
            Calculate();

            //Console.ReadLine();
        }

        static void Calculate(double prev = 0)
        {
            Console.WriteLine("Input your first value: ");
            string input = Console.ReadLine();
            if(input != "")
            {
                try
                {
                    double value1 = 0;
                    if (input == "prev")
                    {
                        value1 = prev;
                    }else
                    {
                        value1 = double.Parse(input);
                    }

                    Console.WriteLine("Input your desired operation: ");
                    string operation = Console.ReadLine();
                    Console.WriteLine("Input your second value: ");
                    input = Console.ReadLine();
                    double value2 = 0;

                    if (input == "prev")
                    {
                        value2 = prev;
                    }else
                    {
                        value2 = double.Parse(input);
                    }

                    if (operation == "+")
                    {
                        Console.WriteLine(value1 + "+" + value2);
                        prev = value1 + value2;
                        Console.WriteLine("= " + prev);
                    }else if (operation == "-")
                    {
                        Console.WriteLine(value1 + "-" + value2);
                        prev = value1 - value2;
                        Console.WriteLine("= " + prev);
                    }else if (operation == "*")
                    {
                        Console.WriteLine(value1 + "*" + value2);
                        prev = value1 * value2;
                        Console.WriteLine("= " + prev);
                    }else if (operation == "/")
                    {
                        if (value2 == 0)
                        {
                            Console.WriteLine("Value is undefined. You cannot divide by 0.");
                        }else
                        {
                            Console.WriteLine(value1 + "/" + value2);
                            prev = value1 / value2;
                            Console.WriteLine("= " + prev);
                        }
                    }else if (operation == "^" || operation == "**")
                    {
                        Console.WriteLine(value1 + "^" + value2);
                        prev = Math.Pow(value1, value2);
                        Console.WriteLine("= " + prev);
                    }else
                    {
                        Console.WriteLine("The operation you entered was not an available operation. Try Again.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The value you just entered was not a number");
                    Console.WriteLine("Try again");
                }
                Calculate(prev);
            }
        }
    }
}
