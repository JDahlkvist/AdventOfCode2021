int horizontal = 0;
int depth = 0;

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
        depth -= distance;
        if (depth < 0) depth = 0;
    }
    else if (String.Compare(direction, "down", StringComparison.OrdinalIgnoreCase) == 0)
    {
        depth += distance;
    }
    else if(String.Compare(direction, "forward", StringComparison.OrdinalIgnoreCase)== 0)
    {
        horizontal += distance;
    }
}