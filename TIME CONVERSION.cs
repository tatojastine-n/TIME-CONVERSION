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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string hoursStr = s.Substring(0, 2);
        string minsStr = s.Substring(3, 2);
        string secsStr = s.Substring(6, 2);
        string period = s.Substring(8, 2);
        int hours = int.Parse(hoursStr);
        if (period == "PM" && hours != 12)
        {
            hours += 12;
        }
        else if (period == "AM" && hours == 12)
        {
            hours = 0;
        }
        string result = hours.ToString("D2") + ":" + minsStr + ":" + secsStr;
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
