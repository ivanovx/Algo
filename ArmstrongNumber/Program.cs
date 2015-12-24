using System;
	
namespace ArmstrongNumber
{
    class ArmstrongNumber
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a one number: ");
            
			int num = int.Parse(Console.ReadLine());
            int n = num;
            int check = 0;
            int remainder;
            
			while (num > 0)
            {
                remainder = num % 10;
                check = check + (int) Math.Pow(remainder, 3);
                num = num / 10;
            }
			
            if (check == n)
            {
                Console.WriteLine(n + " is an Armstrong Number");
            }
            else
            {
                Console.WriteLine(n + " is not a Armstrong Number");
            }
        }
    }

}
