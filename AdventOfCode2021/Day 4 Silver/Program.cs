var inputLines = TextHelper.InputReader.GetInputLines();

string[] drawOrder = null;


List<int[,]> bricks = new List<int[,]>();

int[,]? brick = null;
int? brickLine = null;
foreach (var line in inputLines)
{
    if (line.Contains(',')) { drawOrder = line.Split(',', StringSplitOptions.RemoveEmptyEntries); }
    else if (line.Length > 0)
    {
        if (brick == null)
        {
            brick = new int[5, 5];
            brickLine = 0;
        }
        var brickLineValues = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < brickLineValues.Length; i++)
        {
            brick[brickLine.Value, i] = Int32.Parse(brickLineValues[i]);
        }

        if (brickLine == 4) bricks.Add(brick);
        else brickLine++;
    }
    else
    {
        brick = null;
        brickLine = null;
    }

}

var apa = 0;