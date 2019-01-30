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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(long[] arr)
    {
        long minSum = arr.OrderBy(x => x).Take(4).Sum();
        long maxSum = arr.OrderByDescending(x => x).Take(4).Sum();
        System.Console.WriteLine($"{minSum} {maxSum}");
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Provide Input:");
        long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
