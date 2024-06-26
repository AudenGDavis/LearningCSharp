using System;

namespace MyCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the first number to add:");

            string? userInput = Console.ReadLine();

            float firstValue;
            while(!float.TryParse(userInput, out firstValue)){
                System.Console.WriteLine("incorrect format, try again:");
                userInput = Console.ReadLine();

            }

            System.Console.WriteLine("enter the second number to add:");

            userInput = Console.ReadLine();

            float secondValue;
            while(!float.TryParse(userInput, out secondValue)){
                System.Console.WriteLine("incorrect format, try again:");
                userInput = Console.ReadLine();

            }

            System.Console.WriteLine($"{firstValue} + {secondValue} = {firstValue + secondValue}");



        }
    }
}