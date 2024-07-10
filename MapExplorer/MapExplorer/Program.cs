using System;

namespace MapExplorer
{
    public class MainClass
    {
        
        public static void Main(string[] args)
        {
            String[,] map = new string[10,10];

            string fileContent = File.ReadAllText("./map.txt");
            System.Console.WriteLine(fileContent);
        }
    }
}