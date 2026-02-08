namespace Question5
{
    public static class DigitSorter
    {
        public static int SortDescending(int number)
        {
            return int.Parse(
                string.Concat(
                    number
                        .ToString()
                        .OrderByDescending(c => c)
                )
            );
        }
    }

}
