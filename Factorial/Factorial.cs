namespace Factorial
{
    using System;

    class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a one number: ");
            int num = int.Parse(Console.ReadLine());
            int result = 1;
            while (num > 0)
            {
                result = result * num;
                num--;
            }
           Console.WriteLine("Factorial is: " + result);
        }
    }
}
