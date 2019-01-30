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

    // Complete the staircase function below.
    static void staircase(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Display((n - 1) - i, i + 1);
        }
    }

    static void Display(int space, int hashCount)
    {
        for (int i = 0; i < space; i++)
        {
            System.Console.Write(" ");
        }
        for (int i = 0; i < hashCount; i++)
        {
            System.Console.Write("#");
        }
        System.Console.WriteLine();
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Provide Input:");
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
