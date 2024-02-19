using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{
    public static int anagram(string s)
    {
        if (s.Length % 2 == 0)
        {
            var midpoint = s.Length / 2;
            var count = 0;

            var a = s.ToCharArray().Take(midpoint).ToArray();
            var b = s.ToCharArray().Skip(midpoint).ToList();

            foreach (char c in a)
            {
                if (b.Contains(c))
                {
                    b.Remove(c);
                }
                else
                {
                    count++;
                }
            }

            return count;
        }

        return -1;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.anagram(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
