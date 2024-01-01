// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

String[] lines;
lines = File.ReadAllLines("../../../../input.txt");

int sum = 0;

foreach (String line in lines)
{
    int red = 0;
    int green = 0;
    int blue = 0;

    String[] sets = line.Split(':')[1].Split(';');

    foreach (String set in sets)
    {
        foreach (String cube in set.Split(','))
        {
            int num = int.Parse(cube.Substring(1).Split(' ')[0]);
            String color = cube.Substring(1).Split(' ')[1];

            switch (color)
            {
                case "red":
                    {
                        if (red < num)
                            red = num;
                        break;
                    }
                case "green":
                    {
                        if (green < num)
                            green = num;
                        break;
                    }
                case "blue":
                    {
                        if (blue < num)
                            blue = num;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }
    }
    sum += (red * green * blue);
}
Console.WriteLine(sum);