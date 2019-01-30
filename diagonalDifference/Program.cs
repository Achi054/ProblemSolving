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

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr)
    {
        /*
        a[0][0] + a[1][1] + a[2][2] + a[3][3]
        a[0][3] + a[1][2] + a[2][1] + a[3][0]
         */
        var lrDiagonal = 0;
        var rlDiagonal = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            lrDiagonal += arr[i][i];
            rlDiagonal += arr[i][(arr.Length - 1) - i];
        }

        return Math.Abs(lrDiagonal - rlDiagonal);
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Provide Input:");

        int n = Convert.ToInt32(Console.ReadLine());
        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
