using Question6;

class Program
{
    static void Main()
    {
        var input_int = new[] { 1, 3, 5 };
        var input_request = 5;

        var input2_int = new[] { 2, 2, 2 };
        var input2_request = 3;

        var input3_int = new[] { 10, 10, 10 };
        var input3_request = 4;

        Console.WriteLine($"===== Question 6 =====");
        Console.WriteLine($"Input: f([{string.Join(", ", input_int)}],{input_request})  => Output: [{string.Join(", ", Tribonacci.Generate(input_int, input_request))}]");
        Console.WriteLine($"Input: f([{string.Join(", ", input2_int)}],{input2_request})  => Output: [{string.Join(", ", Tribonacci.Generate(input2_int, input2_request))}]");
        Console.WriteLine($"Input: f([{string.Join(", ", input3_int)}],{input3_request})  => Output: [{string.Join(", ", Tribonacci.Generate(input3_int, input3_request))}]");

        Console.ReadLine();
    }


}
