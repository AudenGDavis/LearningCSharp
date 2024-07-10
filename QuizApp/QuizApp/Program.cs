using System;

namespace QuizApp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("started");
            Dictionary<String,int> questions = new Dictionary<string, int>();
            questions.Add("2 + 2 = ",4);
            questions.Add("1 + 5 = ",6);
            questions.Add("1 * 3 = ",3);
            questions.Add("5 + 2 * 4 = ",13);
            questions.Add("6 / 3 = ",2);
            int score = 0;
            
            foreach(KeyValuePair<String, int> question in questions)
            {
                System.Console.Write(question.Key);
                int answer;
                while(!int.TryParse(Console.ReadLine(),out answer))
                {
                    System.Console.WriteLine("invalid answer, try again");
                    System.Console.Write(question.Key);
                }
                if(answer == question.Value)
                {
                    System.Console.WriteLine("Correct!");
                    score += 1;
                }
                else
                {
                    System.Console.WriteLine("incorrect");
                }
            }
                System.Console.WriteLine($"Score: {score}");
        }
    }
}