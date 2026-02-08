namespace Question3
{
    public class AutoSearch
    {
        public static string[] Autocomplete(string search, string[] items, int maxResult)
        {
            if (string.IsNullOrEmpty(search) || items == null)
                return Array.Empty<string>();

            return items
                .Select(item => new
                {
                    Value = item,
                    Index = item.IndexOf(search, StringComparison.OrdinalIgnoreCase)
                })
                .Where(x => x.Index >= 0)
                .OrderBy(x => x.Index)
                .ThenBy(x => x.Value)
                .Take(maxResult)
                .Select(x => x.Value)
                .ToArray();
        }
    }
}
