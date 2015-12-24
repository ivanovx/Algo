using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goro
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a: ");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input b: ");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Input c: ");

            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Input n: ");

            int n = int.Parse(Console.ReadLine());
            int result = 0;

            for (int k = 0; k < n; k++)
            {
                if (a >= b && a >= c && a >= 1)
                {
                    result += a;
                    a--;
                    continue;
                }
                
				if (b >= a && b >= c && b >= 1)
                {
                    result += b;
                    b--;
                    continue;
                }
                
				if (c >= b && c >= a && c >= 1)
                {
                    result += c;
                    c--;
                    continue;
                }
            }
			
            Console.WriteLine("Result is: " + result);
        }
    }
}
