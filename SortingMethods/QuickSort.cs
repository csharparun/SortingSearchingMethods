using System;

namespace SortingMethods
{
    /// <summary>
    ///  time comepletxity O(n log(n) )
    /// </summary>
    public class QuickSort : ISort
    {
        public int[] Sort(int[] input)
        {
            return QuickSortMethod(input, 0, input.Length - 1);
        }

        private int[] QuickSortMethod(int[] array, int l, int h)
        {
            if (l < h)
            {
                int partionIndex = Partition(array, l, h);
                QuickSortMethod(array, l, partionIndex);
                QuickSortMethod(array, partionIndex + 1, h);
            }

            return array;
        }

        private int Partition(int[] array, int l, int r)
        {
            int pivot = array[l];
            int temp = 0;            
            while (true)
            {
                while (pivot > array[l])
                {
                    l++;
                }

                while (pivot < array[r])
                {
                    r--;
                }

                if (l < r)
                {
                    temp = array[l];
                    array[l] = array[r];
                    array[r] = temp;
                }
                else
                {
                    return r;
                }
            }
        }
    }
}