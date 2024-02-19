using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class RomanNumerals
{
    static string DecimalToRoman(int number)
    {
        if (number < 1 || number > 3999)
        {
            throw new ArgumentException(nameof(number), "Invalid number");
        }

        Dictionary<int, string> romanNumeralDictionary = new Dictionary<int, string>()
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" }
        };

        string result = "";

        foreach (var item in romanNumeralDictionary.Reverse())
        {
            if (number <= 0) break;

            while (number >= item.Key)
            {
                result += item.Value;
                number -= item.Key;
            }
        }

        return result;
    }

    static int RomanToDecimal(string s)
    {
        Dictionary<char, int> romanNumeralsDictionary = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int result = 0;

        for(int i = 0; i < s.Length; i++)
        {
            char currentValue = s[i];
            romanNumeralsDictionary.TryGetValue(currentValue, out int num);

            if( i + 1 < s.Length && romanNumeralsDictionary[currentValue] < romanNumeralsDictionary[s[i + 1]] )
            {
                result -= num;
            }
            else
            {
                result += num;
            }
        }

        return result;
    }
}
