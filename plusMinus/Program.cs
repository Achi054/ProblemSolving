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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        decimal negativeCount = 0;
        decimal positiveCount = 0;
        decimal zeroCount = 0;
        foreach (var data in arr)
        {
            if (data < 0) negativeCount += 1;
            else if (data > 0) positiveCount += 1;
            else zeroCount += 1;
        }
        Console.WriteLine((positiveCount / arr.Count()).ToString("N6"));
        Console.WriteLine((negativeCount / arr.Count()).ToString("N6"));
        Console.WriteLine((zeroCount / arr.Count()).ToString("N6"));
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Provide Input:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}
