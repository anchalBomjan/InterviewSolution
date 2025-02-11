using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter number words (type 'exit' to stop): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit") break;

            Console.WriteLine($"Output: {ConvertWordsToNumber(input)}\n");
        }
    }

    static long ConvertWordsToNumber(string input)
    {
        var numberWords = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4}, {"five", 5},
            {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9}, {"ten", 10},
            {"eleven", 11}, {"twelve", 12}, {"thirteen", 13}, {"fourteen", 14},
            {"fifteen", 15}, {"sixteen", 16}, {"seventeen", 17}, {"eighteen", 18},
            {"nineteen", 19}, {"twenty", 20}, {"thirty", 30}, {"forty", 40},
            {"fifty", 50}, {"sixty", 60}, {"seventy", 70}, {"eighty", 80},
            {"ninety", 90}, {"hundred", 100}, {"thousand", 1000},
            {"million", 1000000}, {"billion", 1000000000}
        };

        long total = 0, current = 0;

        foreach (var word in input.ToLower().Split(' '))
        {
            if (numberWords.TryGetValue(word, out int num))
            {
                if (num == 100) current *= num;
                else if (num >= 1000) { total += (current == 0 ? 1 : current) * num; current = 0; }
                else current += num;
            }
        }
        return total + current;
    }
}
