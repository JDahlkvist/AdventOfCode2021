var input = TextHelper.InputReader.GetInputLines().ToList();

int greaterDepthCount = 0;
int? previousDepth = null;

for (int i = 0; i < input.Count; i++)
{
    if (i + 2 > input.Count - 1)
    {
        break;
    }

    var currentDepth = ToValue(input[i], input[i + 1], input[i + 2]);
    if (previousDepth != null)
    {
        if (currentDepth > previousDepth) greaterDepthCount++;
    }
    previousDepth = currentDepth;
}

Console.WriteLine(greaterDepthCount);

static int ToValue(string val1, string val2, string val3)
{
    return Int32.Parse(val1) + Int32.Parse(val2) + Int32.Parse(val3);
}

