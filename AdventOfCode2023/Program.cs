// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

String[] lines;

lines = File.ReadAllLines("../../../../input.txt");
int total = 0;

for (int i = 0; i < lines.Length; i++)
{
    String s = "";
    int j = 0;
    foreach (char c in lines[i])
    {
        if (c >= 48 & c <= 57)
        {
            s += c;
        }
        switch (c)
        {
            case 'o':
                {
                    if (lines[i].Substring(j).Length >= 3 && lines[i].Substring(j, 3) == "one")
                    {
                        s += '1';
                    }
                    break;
                }
            case 't':
                {
                    if (lines[i].Substring(j).Length >= 3 && lines[i].Substring(j, 3) == "two")
                    {
                        s += '2';
                    }
                    if (lines[i].Substring(j).Length >= 5 && lines[i].Substring(j, 5) == "three")
                    {
                        s += '3';
                    }
                    break;
                }
            case 'f':
                {
                    if (lines[i].Substring(j).Length >= 4 && lines[i].Substring(j, 4) == "four")
                    {
                        s += '4';
                    }
                    if (lines[i].Substring(j).Length >= 4 && lines[i].Substring(j, 4) == "five")
                    {
                        s += '5';
                    }
                    break;
                }
            case 's':
                {
                    if (lines[i].Substring(j).Length >= 3 && lines[i].Substring(j, 3) == "six")
                    {
                        s += '6';
                    }
                    if (lines[i].Substring(j).Length >= 5 && lines[i].Substring(j, 5) == "seven")
                    {
                        s += '7';
                    }
                    break;
                }
            case 'e':
                {
                    if (lines[i].Substring(j).Length >= 5 && lines[i].Substring(j, 5) == "eight")
                    {
                        s += '8';
                    }
                    break;
                }
            case 'n':
                {
                    if (lines[i].Substring(j).Length >= 4 && lines[i].Substring(j, 4) == "nine")
                    {
                        s += '9';
                    }
                    break;
                }
            case 'z':
                {
                    if (lines[i].Substring(j).Length >= 4 && lines[i].Substring(j, 4) == "zero")
                    {
                        s += '0';
                    }
                    break;
                }
            default:
                {
                    break;
                }
        }
        j++;
    }
    lines[i] = s;
}
Regex rx = new Regex("[^0-9-]");

foreach (String line in lines)
{
    String s = rx.Replace(line, "");
    String t = "" + s[0] + s[s.Length - 1];

    total += int.Parse(t);
}

Console.WriteLine(total);