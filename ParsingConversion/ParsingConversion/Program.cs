using System;

namespace ParsingConversion
{
    class MainClass
    {
        static public void Main(string[] args)
        {
            string numString = "123";
            int myNum = int.Parse(numString);
            Console.WriteLine($"num: {myNum}");

            string boolString = "true";
            bool myBool = Convert.ToBoolean(boolString);
            System.Console.WriteLine($"myBool: {myBool}");
        }
    }
}