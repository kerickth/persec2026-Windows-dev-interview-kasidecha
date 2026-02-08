using Question2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Question 2 ===");
        var input1 = new[] { "TH19", "SG20", "TH2" };
        var result1 = SortHelper.Sort(input1);

        Console.WriteLine("Case 1:");
        Console.WriteLine("Input : [" + string.Join(", ", input1) + "]");
        Console.WriteLine("Output : [" + string.Join(", ", result1) + "]");

        var input2 = new[] { "TH10", "TH3Netflix", "TH1", "TH7" };
        var result2 = SortHelper.Sort(input2);

        Console.WriteLine("Case 2:");
        Console.WriteLine("Input : [" + string.Join(", ", input2) + "]");
        Console.WriteLine("Output : [" + string.Join(", ", result2) + "]");

        Console.ReadLine();
    }
}
