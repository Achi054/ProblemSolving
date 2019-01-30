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

class Solution
{

    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar)
    {
        return ar.GroupBy(x => x)
        .Select(x => new { Value = x.Key, Count = x.Count() })
        .OrderByDescending(x => x.Value).First().Count;
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Provide Input:");

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
