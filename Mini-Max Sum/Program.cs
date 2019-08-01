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
    static void miniMaxSum(int[] arr)
    {
        long sumOfNumbers = 0;
        long iMax = 0;
        long iMin = Int64.MaxValue;

        foreach (int iNumber in arr)
        {
            sumOfNumbers += iNumber;
            if (iNumber < iMin)
            {
                iMin = iNumber;
            }
            if (iNumber > iMax)
            {
                iMax = iNumber;
            }
        }
        Console.WriteLine("{0} {1}", sumOfNumbers - iMax, sumOfNumbers - iMin);
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
