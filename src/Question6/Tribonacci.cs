namespace Question6
{
    public static class Tribonacci
    {
        public static List<int> Generate(int[] startValues, int count)
        {
            var result = new List<int>(startValues);
            var buffer = new List<int>();
            var count_array = startValues.Length;

            for (int i = 0; i < count; i++)
            {
                int sum = result
                    .TakeLast(3)
                    .Sum();
                if (count > count_array)
                {
                    result.Add(sum);
                }

                buffer.Add(result[i]);
            }
            result.Clear();
            result = buffer;


            return result;
        }
    }
}
