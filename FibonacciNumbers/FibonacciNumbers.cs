using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a one number: ");
            int num = int.Parse(Console.ReadLine());
            int f1;
            int f2 = 0;
            int f3 = 1;

            Console.WriteLine("Fibonacci numbers");

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
            }
        }
    }
}
