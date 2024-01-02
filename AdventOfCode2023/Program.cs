String[] lines;
lines = File.ReadAllLines("../../../../input.txt");
int sum = 0;

// Y coordinate; moves vertically through input
for (int y = 0; y < lines.Length; y++)
{
    // X coordinate: moves horizontally through each line of input
    for (int x = 0; x < lines[y].Length; x++)
    {
        // Checks if coordinate y,x has an asterisk
        if (lines[y][x] == '*')
        {
            int[] nums = [];
            string[] coords = [];

            // Modifier for Y coordinate; moves vertically centered on gear
            for (int i = -1; i < 2; i++)
            {
                // Modifier for X coordinate; moves horizontally centered on gear
                for (int j = -1; j < 2; j++)
                {

                    // Checks every tile in input for a digit character
                    if (lines[y + i][x + j] >= '0' && lines[y + i][x + j] <= '9')
                    {
                        int minX = int.MaxValue;
                        String num = "";

                        // Goes as far left as possible on each number and records the X coordinate of the first digit
                        for (int k = 0; x + j + k >= 0 && lines[y + i][x + j + k] >= '0' && lines[y + i][x + j + k] <= '9'; k--)
                            minX = x + j + k;

                        // Records value of the number found as a string
                        for (int k = 0; minX + k < lines[y].Length && lines[y + i][minX + k] >= '0' && lines[y + i][minX + k] <= '9'; k++)
                            num += lines[y + i][minX + k];

                        // If the coordinate of the number found does not already exist in the "coords" array...
                        if (!coords.Contains(minX + ", " + (y + i)))
                        {
                            // Expand each array,
                            Array.Resize(ref nums, nums.Length + 1);
                            Array.Resize(ref coords, coords.Length + 1);
                            // input the found number as an int...
                            nums[^1] = int.Parse(num);
                            // and input the coordinate pair as a string in the form "x, y".
                            coords[^1] = minX + ", " + (y + i);
                            Console.WriteLine("Integer " + num + " found at coordinates " + (y + i) + ", " + minX + "-" + (minX + num.Length));
                        }
                    }
                } // End of row surrounding asterisk
            } // Finished processing asterisk

            if (nums.Length == 2)
            {
                Console.WriteLine("Two numbers found: " + nums[0] + " and " + nums[1]);
                Console.WriteLine(nums[0] + " * " + nums[1] + " added to sum.");
                sum += nums[0] * nums[1];
                Console.WriteLine("Sum is now " + sum);
            }
            else if (nums.Length == 1)
            {
                Console.WriteLine("Only one number found: " + nums[0]);
            }
        }
    }
}
Console.WriteLine("The sum of the Gear Ratios is " + sum);