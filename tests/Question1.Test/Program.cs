using Question1;

class Program
{
    static void Main()
    {
        RunQuestion1();
    }

    static void RunQuestion1()
    {
        Console.WriteLine("=== Question 1 ===");

        string[] cases =
        {
            "()",
            "()[]{}",
            "(]",
            "([)]",
            "{[]}"
        };

        foreach (var c in cases)
        {
            Console.WriteLine($"{c} => {BracketValidator.IsValid(c)}");
        }

        Console.ReadLine();
    }
}
