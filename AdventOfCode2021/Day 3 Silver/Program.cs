int[,] binaryArr = null;
foreach (var line in TextHelper.InputReader.GetInputLines())
{
    if (binaryArr == null) { binaryArr = new int[line.Length, 2]; }
    for (int i = 0; i < line.Length; i++)
    {
        binaryArr[i, Convert.ToInt32(line[i].ToString())] += 1;
    }
}

string gamma = string.Empty;
for (int i = 0; i < binaryArr.Length / 2; i++)
{
    gamma += binaryArr[i, 0] > binaryArr[i, 1] ? 0 : 1;
}

string epsilon = string.Empty;
foreach (var item in gamma)
{
    epsilon += item == '1' ? '0' : '1';
}

var gammaDecimal = Convert.ToInt32(gamma, 2);
var epsilonDecimal = Convert.ToInt32(epsilon, 2);

Console.WriteLine(gammaDecimal * epsilonDecimal);
