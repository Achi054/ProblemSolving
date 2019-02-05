using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        DateTime d = DateTime.Parse(s);
        return d.ToString("HH:mm:ss");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Provide Input:");
        string s = Console.ReadLine();
        string result = timeConversion(s);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
