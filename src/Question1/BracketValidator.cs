using System.Collections.Generic;

namespace Question1
{
    public class BracketValidator
    {
        public static bool IsValid(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            var stack = new Stack<char>();
            var pairs = new Dictionary<char, char>
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };

            foreach (var ch in input)
            {
                if (pairs.ContainsValue(ch))
                {
                    stack.Push(ch);
                }
                else if (pairs.ContainsKey(ch))
                {
                    if (stack.Count == 0 || stack.Pop() != pairs[ch])
                        return false;
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
