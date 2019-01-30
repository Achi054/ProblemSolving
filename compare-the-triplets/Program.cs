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

class CompareTheTriplets
{

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var aWinCount = 0;
        var bWinCount = 0;
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] < b[i]) bWinCount++;
            else if (a[i] > b[i]) aWinCount++;
            else continue;
        }
        return new List<int> { aWinCount, bWinCount };
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Provide Inputs:");
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));
        Console.ReadLine();
    }
}
