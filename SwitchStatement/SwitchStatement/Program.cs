using System;
using System.Security.Cryptography;

namespace SwitchStatement
{
    class MainClass
    {
        static void Main(String[] args)
        {
            Console.Write("enter your favorite ice cream flavor: ");
            String? response = Console.ReadLine();
            
            
            switch (response)
            {
                case "vanilla":
                    System.Console.WriteLine("that's valid");
                    break;
                
                case "chocolate":
                    System.Console.WriteLine("that's valid");
                    break;

                case "mint":
                    System.Console.WriteLine("you have good taste");
                    break;

                case "pistachio":
                    System.Console.WriteLine("you're crazy");
                    break;

                default:
                    System.Console.WriteLine("you didn't pick chocolate, vanilla, or mint therefore you picked wrong");
                    break;
            }
        }
    }
}