using System;
using Question4;

namespace Question4.Test
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Question 4 ===");

            TestIntToRoman(1989);
            TestIntToRoman(2000);
            TestIntToRoman(68);
            TestIntToRoman(109);

            Console.WriteLine();

            TestRomanToInt("MCMXXXIX");
            TestRomanToInt("MM");
            TestRomanToInt("LXVIII");
            TestRomanToInt("CIX");

            Console.ReadLine();
        }

        static void TestIntToRoman(int number)
        {
            var roman = RomanNumeralConverter.IntToRoman(number);
            Console.WriteLine($"Input  : {number}");
            Console.WriteLine($"Output : {roman}\n");
        }

        static void TestRomanToInt(string roman)
        {
            var number = RomanNumeralConverter.RomanToInt(roman);
            Console.WriteLine($"Input  : {roman}");
            Console.WriteLine($"Output : {number}\n");
        }
    }
}
