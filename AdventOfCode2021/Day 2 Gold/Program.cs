// See https://aka.ms/new-console-template for more information

int horizontal = 0;
int depth = 0;
int aim = 0;

foreach (string line in TextHelper.InputReader.GetInputLines())
{
    var values = line.Split(new[] { ' ' });
    AddOrSubtract(values[0], Int32.Parse(values[1]));
}
Console.WriteLine(horizontal * depth);

void AddOrSubtract(string direction, int distance)
{
    if(String.Compare(direction, "up", StringComparison.OrdinalIgnoreCase) == 0)
    {
        aim -= distance;
    }
    else if (String.Compare(direction, "down", StringComparison.OrdinalIgnoreCase) == 0)
    {
        aim += distance;
    }
    else if(String.Compare(direction, "forward", StringComparison.OrdinalIgnoreCase)== 0)
    {
        horizontal += distance;
        depth += distance * aim;
        if (depth < 0) depth = 0;
    }
}