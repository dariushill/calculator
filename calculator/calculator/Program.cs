﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result = 0;
            string answer;

            Console.WriteLine("Hello, welcome to the calculator program!");

            Console.WriteLine("Enter your first number: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do? ");
            Console.WriteLine("Please enter 'a' for addition, 's' for subtraction, 'm' for multiplication, or 'd' for division");


            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else if (answer == "d")
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Please enter a valid key");
            }

            Console.WriteLine("The result is " + result);
            Console.ReadKey();
        }
    }
}
