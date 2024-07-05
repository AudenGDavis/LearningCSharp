using System;
using System.Net.Mail;

namespace StringFormatting
{
    class MainClass
    {
        static public void Main(string[] args)
        {
            int num = 100;
            double price = 19.99;
            string name = "auden";
            
            System.Console.WriteLine("number is {0} \nthe price is {1} \nmy name is {2}", num, price, name);  
        }
    }
}