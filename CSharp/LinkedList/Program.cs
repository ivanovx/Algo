using System;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new LinkedList<int>();

            for (int i = 0; i < 15; i++)
            {
                numbers.PushFront(i + 1);
            }

            var index = numbers.GetEnumerator();

            while (index.MoveNext())
            {
                Console.WriteLine(index.Current);
            }
        }
    }
}
