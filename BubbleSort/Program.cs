namespace BubbleSort
{
    using System;
    class BubbleSort
    {
        static void Main(string[] args)
        {

            int[] intArray = new int[] { 5, 90, 35, 45, 150, 3 };

            Console.WriteLine("Besore bubble sort");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            bubbleSort(intArray);

            Console.WriteLine("After bubble sort");

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }
        private static void bubbleSort(int[] intArray)
        {
            int n = intArray.Length;
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < (n - i); j++)
                {
                    if (intArray[j - 1] > intArray[j])
                    {
                        temp = intArray[j - 1];
                        intArray[j - 1] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
        }
    }
}