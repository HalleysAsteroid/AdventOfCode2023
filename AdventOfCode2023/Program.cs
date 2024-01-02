String[] lines;
lines = File.ReadAllLines("../../../../input.txt");
int sum = 0;

foreach (String line in lines)
{
    int points = 0;

    foreach (string cardNum in line.Split(':')[1].Split('|')[1].Split(' '))
    {
        if ((cardNum != "") && line.Split(':')[1].Split('|')[0].Split(' ').Contains(cardNum))
        {
            if (points == 0)
                points = 1;
            else points = points * 2;
        }

    }
    sum += points;
}
Console.WriteLine(sum);