namespace SearchMethods
{
    public class LinearSearch : ISearch
    {
        public int Search(int[] input, int key)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == key)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}