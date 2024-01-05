String[] lines;
lines = File.ReadAllLines("../../../../input.txt");
int sum = 0;

for (int i = 0; i < lines.Length; i++)
{
    sum += CardCounter(i);
}
Console.WriteLine(sum);

static int CardCounter(int cardID)
{
    String[] lines;
    lines = File.ReadAllLines("../../../../input.txt");


    int winners = 0;
    int sum;


    foreach (string cardNum in lines[cardID - 1].Split(':')[1].Split('|')[1].Split(' '))
    {
        if ((cardNum != "") && lines[cardID - 1].Split(':')[1].Split('|')[0].Split(' ').Contains(cardNum))
        {
            winners++;

        }

    }

    for (int i = 0; i < winners; i++)





}