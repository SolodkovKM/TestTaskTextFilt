using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Stredit("123!2Da"));
    }
    public static string Stredit(string instring)
    {
        string outstring = instring.ToLower();
        var rep = outstring.ToCharArray().GroupBy(e => e).Where(t => t.Equals(t)).ToList();
        for (int i = 0; i < rep.Count; i++)
        {
            if (rep[i].Count() > 1)
            {
                outstring = outstring.Replace(rep[i].Key, ')');
            }
            else
            {
                outstring = outstring.Replace(rep[i].Key, '(');
            }
        }
        return outstring;
    }
}