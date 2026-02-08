using System;
using System.Collections.Generic;

namespace Question4
{
    public static class RomanNumeralConverter
    {
        private static readonly Dictionary<int, string> IntToRomanMap = new()
        {
            {1000, "M"},
            {900,  "CM"},
            {500,  "D"},
            {400,  "CD"},
            {100,  "C"},
            {90,   "XC"},
            {50,   "L"},
            {40,   "XL"},
            {10,   "X"},
            {9,    "IX"},
            {5,    "V"},
            {4,    "IV"},
            {1,    "I"}
        };

        private static readonly Dictionary<char, int> RomanToIntMap = new()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static string IntToRoman(int number)
        {
            var result = string.Empty;

            foreach (var pair in IntToRomanMap)
            {
                while (number >= pair.Key)
                {
                    result += pair.Value;
                    number -= pair.Key;
                }
            }

            return result;
        }

        public static int RomanToInt(string roman)
        {
            int total = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                int current = RomanToIntMap[roman[i]];
                int next = (i + 1 < roman.Length)
                    ? RomanToIntMap[roman[i + 1]]
                    : 0;

                if (current < next)
                    total -= current;
                else
                    total += current;
            }

            return total;
        }
    }
}
