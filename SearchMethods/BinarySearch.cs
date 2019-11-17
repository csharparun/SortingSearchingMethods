using System;

namespace SearchMethods
{
    public class BinarySearch : ISearch
    {
        public int Search(int[] input, int key)
        {
            int left = 0;
            int right = input.Length - 1;

            return BinarySearchMethod(key, input, left, right);
        }

        private int BinarySearchMethod(int key, int[] input, int left, int right)
        {
            int middle = (left + right) / 2;
            if (input[middle] == key)
            {
                return middle;
            }
            else if(left >= right)
            {
                return -1;
            }

            if(input[middle] > key)
            {
                return BinarySearchMethod(key, input, left, middle - 1);
            }
            else
            {
                return BinarySearchMethod(key, input, middle + 1, right);
            }
        }
    }
}