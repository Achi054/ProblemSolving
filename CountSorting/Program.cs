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

    // Complete the countingSort function below.
    static int[] countingSort(int[] arr)
    {
        //Create array of length arr.length with value 0 
        //Foreach items increment value on that index
        int[] countingArr = Enumerable.Repeat(0, 100).ToArray();
        for (int i = 0; i < arr.Length; i++)
        {
            countingArr[arr[i]] += 1;
        }
        return countingArr;
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Provide Input:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        int[] result = countingSort(arr);

        Console.WriteLine(string.Join(" ", result));
        Console.ReadLine();
    }
}
