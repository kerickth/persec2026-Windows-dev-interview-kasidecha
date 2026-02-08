using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Question2
{
    public class SortHelper
    {
        public static string[] Sort(string[] input)
        {
            return input
                .Select(x =>
                {
                    var match = Regex.Match(x, @"^([A-Za-z]+)(\d+)(.*)$");
                    return new
                    {
                        Original = x,
                        Prefix = match.Groups[1].Value,
                        Number = int.Parse(match.Groups[2].Value),
                        Suffix = match.Groups[3].Value
                    };
                })
                .OrderBy(x => x.Prefix)
                .ThenBy(x => x.Number)
                .ThenBy(x => x.Suffix)
                .Select(x => x.Original)
                .ToArray();
        }
    }
}
