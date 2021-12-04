int[,] binaryArr = null;
var inputLines = TextHelper.InputReader.GetInputLines();


foreach (var line in inputLines)
{
    if (binaryArr == null) { binaryArr = new int[line.Length, 2]; }
    for (int i = 0; i < line.Length; i++)
    {
        binaryArr[i, Convert.ToInt32(line[i].ToString())] += 1;
    }
}

var oxygenNumbers = new List<string>(inputLines);
for (int i = 0; i < binaryArr.Length / 2 ; i++)
{
    if (oxygenNumbers.Count == 1) break;

    char? number = null;
    if (binaryArr[i, 0] == binaryArr[i, 1])
    {
        number = '1';
    }
    else
    {
        number = binaryArr[i, 0] > binaryArr[i, 1] ? '0' : '1';
    }
    var hej = oxygenNumbers.Where(x => x.ElementAt(i) != number).ToList();
    foreach (var oxygenNumber in hej)
    {
        oxygenNumbers.Remove(oxygenNumber);
    }
}

var co2ScrubberNumbers = new List<string>(inputLines);
for (int i = 0; i < binaryArr.Length / 2; i++)
{
    if (co2ScrubberNumbers.Count == 1) break;

    char? number = null;
    if (binaryArr[i, 0] == binaryArr[i, 1])
    {
        number = '0';
    }
    else
    {
        number = binaryArr[i, 0] < binaryArr[i, 1] ? '0' : '1';
    }
    var toBeAdded = co2ScrubberNumbers.Where(x => x.ElementAt(i) == number);
    co2ScrubberNumbers = new List<string>(toBeAdded);
}
var oxyRating = Convert.ToInt64(oxygenNumbers.Single(), 2);
var co2Rating = Convert.ToInt64(co2ScrubberNumbers.Single(), 2);
var lifeSupportRating = oxyRating * co2Rating;
Console.WriteLine("oxy:" + oxyRating);
Console.WriteLine("co2:" + co2Rating);
Console.WriteLine(lifeSupportRating);


//guess: 2002077 too high