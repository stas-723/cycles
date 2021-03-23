using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи число:");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            Console.WriteLine($"A в степени B = {result}");


        }
    }
}
