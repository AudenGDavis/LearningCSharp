using System;

namespace ImplicitConversion
{
    class MainClass
    {
        public static void Main(string [] args)
        {
            uint myInt = 13;
            double myDouble = myInt;
            ulong myLong = myInt;
            System.Console.WriteLine($"myInt: {myInt}");
            System.Console.WriteLine($"myDouble: {myDouble}");
        }
    }
}
