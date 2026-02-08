using Question5;

class Program
{
    static void Main()
    {
        int[] inputs = { 3008, 1989, 2679, 9163 };

        Console.WriteLine($"===== Question 5 =====");

        foreach (var input in inputs)
        {
            var result = DigitSorter.SortDescending(input);
            Console.WriteLine($"{input} => {result}");
        }

        Console.ReadLine();
    }
}
