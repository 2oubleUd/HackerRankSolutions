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
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */
    
    public static string gridChallenge(List<string> grid)
    {
        int columns = grid[0].Length;
        int rows = grid.Count();

        List<string> columnList = new List<string>();
        for (int j = 0; j < columns; j++)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                grid[i] = String.Concat(grid[i].OrderBy(c => c));
                sb.Append(grid[i][j]);
            }
            columnList.Add(sb.ToString());

            if (columnList[j] != String.Concat(columnList[j].OrderBy(c => c)))
            {
                return "NO";
            }
            if (columnList[j] == String.Concat(columnList[j].OrderBy(c => c)))
            {
                continue;
            }
        }

        return "YES";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = Result.gridChallenge(grid);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
