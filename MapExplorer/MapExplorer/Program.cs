using System;
using System.Collections;

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

        public static String[,] openMap(string fileName, int height, int width)
        {
            ArrayList<ArrayList<string>> returnArray;

            string fileContent;
            try
            {
                fileContent = File.ReadAllText(fileName);
            }
            catch(Exception e)
            {
                return null;
            }

            int x = 0;
            int y = 0;

            foreach(char theChar in fileContent.ToCharArray())
            {
                if(theChar == '\n')
                {
                    y++;
                }
                else 
                {

                }
            }
        }
    }
}