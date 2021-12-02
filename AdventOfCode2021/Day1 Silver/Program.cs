// See https://aka.ms/new-console-template for more information

int greaterDepthCount = 0;
int? previousDepth = null;
foreach (string line in TextHelper.InputReader.GetInputLines())
{
    int currDepth = Int32.Parse(line);
    if (previousDepth != null)
    {
        if(currDepth > previousDepth) greaterDepthCount++;
    }
    previousDepth = currDepth;
}
Console.WriteLine(greaterDepthCount);