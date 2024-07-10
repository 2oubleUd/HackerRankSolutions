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

    /*
     * Complete the 'superGrid' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2.INTEGER k
     */

    private static int superDigit(long input)
    {

        if (input < 10) return (int)input;
        long sum = 0;
        while (input > 0)
        {
            sum += input % 10; // 11 % 10 = 1 -> 1 % 10 = 1
            input /= 10; // 11 / 10 = 1 -> 1 / 10 == 0
        }
        return superDigit(sum);
    }

    public static int superDigit(string n, int k)
    {
        long num = 0;

        foreach (char c in n)
        {
            num += c - '0';
        }

        num *= k;

        return superDigit(num);
    }
}


class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();

    }
}
