namespace SortingMethods
{
    /// <summary>
    /// time complexity o(n2)
    /// </summary>
    public class SelectionSort : ISort
    {
        public int[] Sort(int[] input)
        {
            for (int j = input.Length - 1; j > 0; j--)
            {
                int max = input[0];
                int maxIndex = 0;
                for (int i = 1; i <= j; i++)
                {
                    if (input[i] > max)
                    {
                        max = input[i];
                        maxIndex = i;
                    }
                }

                int temp = input[j];
                input[j] = max;
                input[maxIndex] = temp;
            }

            return input;
        }
    }
}