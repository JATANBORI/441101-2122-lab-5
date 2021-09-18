using System;

namespace L5._2_AdditionChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Addition Challenge.");

            int operand1, operand2, results;
            int correct = 0;
            int wrong = 0;
            const int maxAttempts = 5;
            int attempt = 0;
            Random randnumber = new Random();

            while (true)
            {
                operand1 = randnumber.Next(100, 501);
                operand2 = randnumber.Next(100, 501);
                results = operand1 + operand2;
                attempt ++;

                Console.Write(operand1 + " + " + operand2 + " = ");

                int answer = int.Parse(Console.ReadLine());

                // Continue your codes from here
                

            }

            Console.WriteLine("Correct: " + correct);
            Console.WriteLine("Wrong: " + wrong);
            Console.WriteLine("Total Answered: " + (correct + wrong));

        }
    }
}
