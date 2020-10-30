//This is a C# 4 operators basic calculator program
using System;

namespace Calculator.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: "); //Prompts user to enter the first number
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Operator: ");//Prompts user to enter the operator they want to use
            string op = Console.ReadLine();
            
            Console.Write("Enter a number: ");//Prompts user to enter the second number
            double num2 = Convert.ToDouble(Console.ReadLine());

//Calculates and prints out the result
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator"); //If user enters an operator not mentioned above
            }
        }
    }
}