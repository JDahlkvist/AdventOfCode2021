
var inputLines = TextHelper.InputReader.GetInputLines();

var binRates = inputLines.ToList();

Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

List<string> zeros = null;
List<string> ones = null;

string oxygenRate = String.Empty;
for (int i = 0; i < inputLines.First().Length; i++)
{
    ones = new List<string>();
    zeros = new List<string>();

    foreach (var line in binRates)
    {
        if (line[i] == '1') ones.Add(line);
        else zeros.Add(line);
    }
    if (ones.Count() == 1 && zeros.Count() == 0 || (ones.Count() == 1 && zeros.Count() == 1)) { oxygenRate = ones[0]; break; }
    if (ones.Count() == 0 && zeros.Count == 1) { oxygenRate = zeros[0]; break; }

    if (ones.Count() > zeros.Count() || ones.Count() == zeros.Count()) { binRates = new List<string>(ones); }
    else { binRates = new List<string>(zeros); }
}

binRates = inputLines.ToList();
string co2Rate = String.Empty;
for (int i = 0; i < inputLines.First().Length; i++)
{
    ones = new List<string>();
    zeros = new List<string>();

    foreach (var line in binRates)
    {
        if (line[i] == '1') ones.Add(line);
        else zeros.Add(line);
    }
    if ((ones.Count() == 0 && zeros.Count == 1) || (ones.Count() ==1 && zeros.Count() == 1)) { co2Rate = zeros[0]; break; }
    if (ones.Count() == 1 && zeros.Count() == 0) { co2Rate = ones[0]; break; }

    if (zeros.Count() < ones.Count() || ones.Count() == zeros.Count()) { binRates = new List<string>(zeros); }
    else { binRates = new List<string>(ones); }
}

var oxyRating = Convert.ToInt64(oxygenRate, 2);
var co2Rating = Convert.ToInt64(co2Rate, 2);
var lifeSupportRating = oxyRating * co2Rating;
Console.WriteLine("oxy:" + oxyRating);
Console.WriteLine("co2:" + co2Rating);
Console.WriteLine(lifeSupportRating);