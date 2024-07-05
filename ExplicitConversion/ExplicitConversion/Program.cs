using System;

namespace ExplicitConversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long myLong = 123456789123456789;
            System.Console.WriteLine(myLong);
            
            int myInt = (int)myLong;
            System.Console.WriteLine(myInt);
        }
    }
}