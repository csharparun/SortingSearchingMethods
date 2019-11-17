using System;
using System.Collections.Generic;
using System.Text;

namespace SortingMethods
{
    /// <summary>
    ///  time complexity is O(n2)
    /// </summary>

    public class BubbleSort : ISort
    {
        public int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - i - 1; j++)
                {                    
                    if (input[j] > input[j + 1])
                    {
                        Swap(input, j, j + 1);
                    }
                }
            }

            return input;
        }

        private void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
