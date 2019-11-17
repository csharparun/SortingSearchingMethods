namespace SortingMethods
{
    /// <summary>
    /// Time complexity O(n2)
    /// </summary>
    public class InsertionSort : ISort
    {
        public int[] Sort(int[] input)
        {
            for (int i = 1; i <= input.Length - 1; i++)
            {
                int temp = input[i];
                for (int j = i - 1; j >= 0  && temp < input[j]; j--)
                {
                    input[j + 1] = input[j];
                    input[j] = temp;
                }
            }

            return input;
        }
    }
}