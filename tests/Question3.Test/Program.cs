
using Question3;

class Program
{
    static void Main()
    {
        var items = new[] { "Mother", "Think", "Worthy", "Apple", "Android" };
        var search = "th";
        var maxResult = 2;

        var result = AutoSearch.Autocomplete(search, items, maxResult);

        Console.WriteLine("===== Question 3 =====");
        Console.WriteLine("Input : [" + string.Join(", ", items) + "]");
        Console.WriteLine("Search : " + search);
        Console.WriteLine("MaxResult : " + maxResult);
        Console.WriteLine("Output: [" + string.Join(", ", result) + "]");

        Console.ReadLine();
    }
}
