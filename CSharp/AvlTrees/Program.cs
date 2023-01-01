using System;

namespace AvlTrees
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Avl<int> set = new Avl<int>();

            int[] numbers = new int[] { 64, 12, 10, 0, 4, 7, 11 };

            foreach (int x in numbers)
            {
                set.Add(x);
            }

            Console.WriteLine("Size is {0}", set.Size);

            foreach (int x in set)
            {
                Console.WriteLine(x);
            }

            set.Remove(12);
            set.Remove(8);

            Console.WriteLine("Size is {0}", set.Size);

            foreach (var x in set)
            {
                Console.WriteLine(x);
            }
        }
    }
}
