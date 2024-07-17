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
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Dynamic;

class Result
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */
    private static IList<T> Swap<T>(IList<T> list, int indexA, int indexB)
    {
        T tmp = list[indexA];
        list[indexA] = list[indexB];
        list[indexB] = tmp;
        return list;
    }
    public static void minimumBribes(List<int> q)
    {
        int bribes = 0;
        List<int> ordered = new List<int>();
        for (int i = 0; i < q.Count; i++) ordered.Add(i + 1);

        for (int i = 0; i < q.Count; i++)
        {
            if (q[i] == ordered[i]) continue;
            if (q[i] != ordered[i])
            {
                Swap(ordered, i, i + 1);

                if (q[i] != ordered[i])
                {
                    Swap(ordered, i, i + 2);
                    if (q[i] == ordered[i]) bribes += 2;
                    else
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                }
                else bribes++;
            }
        }
        Console.WriteLine(bribes);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.minimumBribes(q);
        }
    }
}
