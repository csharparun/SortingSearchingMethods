using System;

namespace SearchMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 40, 12, 35, 55, 21, 80, 65 };

            BinarySearch b = new BinarySearch();
            int result = b.Search(input, 100);

            LinearSearch l = new LinearSearch();
            result = l.Search(input, 55);
        }

        private static void SearchResult(int result)
        {            
            if (result != -1)
            {
                Console.WriteLine($"Element {55} is present at index {result} ");
            }
            else
            {
                Console.WriteLine("Element is not found in the given array");
            }
        }
    }
}
