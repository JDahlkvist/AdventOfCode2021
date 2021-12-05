var inputLines = TextHelper.InputReader.GetInputLines();

int? answer = 0;
string[] drawOrder = null;
Dictionary<int, string[,]> _boards = new Dictionary<int, string[,]>();

CreateBoardsAndDrawOrder();
for (int i = 0; i < drawOrder.Length; i++)
{
    for (int j = 0; j < _boards.Keys.Count - 1; j++)
    {
        answer = MarkEachBoardAndSearchForBingo(_boards[j], drawOrder[i]).Value;
        if (answer.HasValue) break;
    }
    if (answer.HasValue) break;
}

Console.WriteLine(answer);


//Methods
int? MarkEachBoardAndSearchForBingo(string[,] board, string number)
{
    board.

    bool bingo = false;
    //Mark number as X if found
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if(board[i,j] == number)
            {
                board[i, j] = "X";
            }
        }
    }

    var apa = 2;
    //Search for 5 X horizontally
    for (int i = 0; i < board.Length; i++)
    {
        string[] row = new string[5];
        board.CopyTo(row, i);

        if (row.All(row => row == "X"))
        {
            bingo = true;
            break;
        };
    }
    return null;
}

string[] GetDimRowVals (string [,] multiDimArr,int  rowNumber)
{
    string[] rowVals = new string[5];
    for (int i = 0;i < multiDimArr.Length; i++)
    {
        rowVals[i] = multiDimArr[rowNumber, i];
    }
    return rowVals;
}

void CreateBoardsAndDrawOrder()
{
    string[,]? board = null;
    int? boardLine = null;
    foreach (var line in inputLines)
    {
        if (line.Contains(',')) { drawOrder = line.Split(',', StringSplitOptions.RemoveEmptyEntries); }
        else if (line.Length > 0)
        {
            if (board == null)
            {
                board = new string[5, 5];
                boardLine = 0;
            }
            var brickLineValues = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < brickLineValues.Length; i++)
            {
                board[boardLine.Value, i] = (brickLineValues[i]);
            }

            if (boardLine == 4)
            {
                var key = !_boards.Keys.Any() ? 0 : _boards.Keys.Max() + 1;
                _boards.Add(key, board);
            }

            else boardLine++;
        }
        else
        {
            board = null;
            boardLine = null;
        }
    }
}


var apa = 0;