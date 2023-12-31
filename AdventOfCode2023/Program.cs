// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

String[] lines;

lines = File.ReadAllLines("../../../../input.txt");
int total = 0;
Regex rx = new Regex("[^0-9-]");

foreach (String line in lines)
{
    String s = rx.Replace(line, "");
    String t = "" + s[0] + s[s.Length - 1];

    total += int.Parse(t);
}

Console.WriteLine(total);