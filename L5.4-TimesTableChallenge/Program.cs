using System;

namespace L5._4_TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Producing the times table
            int product;
            Console.WriteLine("2 - 12 Times Table.");
            Console.WriteLine("==========================");
            for (int i = 2; i < 12; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    product = i * j;
                    Console.WriteLine(i + " x " + j + " = " + product);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();


            
            //The times table challenge...
            Console.WriteLine("The Times Table Challenge.");
            Console.WriteLine("==========================");

            // Your codes here

           

        }
    }
}
