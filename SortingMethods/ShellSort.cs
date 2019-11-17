namespace SortingMethods
{
    public class ShellSort : ISort
    {
        public int[] Sort(int[] input)
        {
            int sequence = 4;
            int k, temp;
            while (sequence > 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    k = i;
                    temp = input[i];
                    while ((k >= sequence) && (input[k - sequence] > temp))
                    {
                        input[k] = input[k - sequence];
                        input[k - sequence] = temp;
                        k = k - sequence;
                    }
                }

                if (sequence / 2 != 0)
                {
                    sequence = sequence / 2;
                }
                else if (sequence == 1)
                {
                    sequence = 0;
                }
                else
                {
                    sequence = 1;
                }
            }

            return input;
        }
    }
}