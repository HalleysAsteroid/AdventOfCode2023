// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

String[] lines;
lines = File.ReadAllLines("../../../../input.txt");
int sum = 0;

for (int y = 0; y < 140; y++)
{
    Console.WriteLine(lines[y].Length);
    for (int x = 0; x < 140; x++)
    {
        Console.WriteLine(x);
        if (lines[y][x] >= 48 & lines[y][x] <= 57)
        {
            String num = "";
            bool isPartNum = false;
            while (x < 140 && lines[y][x] >= 48 && lines[y][x] <= 57)
            {
                num += lines[y][x];

                if (x != 0)
                {
                    if (y != 0)
                        if (lines[y - 1][x - 1] == 47 || lines[y - 1][x - 1] < 46 || lines[y - 1][x - 1] > 57)
                            isPartNum = true;
                    if (lines[y][x - 1] == 47 || lines[y][x - 1] < 46 || lines[y][x - 1] > 57)
                        isPartNum = true;
                    if (y < lines.Length - 1)
                        if (lines[y + 1][x - 1] == 47 || lines[y + 1][x - 1] < 46 || lines[y + 1][x - 1] > 57)
                            isPartNum = true;
                }
                if (y > 0)
                    if (lines[y - 1][x] == 47 || lines[y - 1][x] < 46 || lines[y - 1][x] > 57)
                        isPartNum = true;
                if (y < 140 - 1)
                    if (lines[y + 1][x] == 47 || lines[y + 1][x] < 46 || lines[y + 1][x] > 57)
                        isPartNum = true;
                if (x < 140 - 1)
                {
                    if (y > 0)
                        if (lines[y - 1][x + 1] == 47 || lines[y - 1][x + 1] < 46 || lines[y - 1][x + 1] > 57)
                            isPartNum = true;
                    if (lines[y][x + 1] == 47 || lines[y][x + 1] < 46 || lines[y][x + 1] > 57)
                        isPartNum = true;
                    if (y < 140 - 1)
                        if (lines[y + 1][x + 1] == 47 || lines[y + 1][x + 1] < 46 || lines[y + 1][x + 1] > 57)
                            isPartNum = true;
                }

                x++;
            }
            // Console.WriteLine(num);
            if (isPartNum)
                sum += int.Parse(num);
            //is a number
        }
        else if (lines[y][x] == 46)
        {
            //is a periodt
        }
        else
        {
            //is a symbol
        }

    }
}
Console.WriteLine(sum);