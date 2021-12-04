var inputLines = TextHelper.InputReader.GetInputLines();

string[] drawOrder = null;
List<int[,]> _boards = new List<int[,]>();

CreateBoardsAndDrawOrder();


//Methods
void CreateBoardsAndDrawOrder()
{
    int[,]? board = null;
    int? boardLine = null;
    foreach (var line in inputLines)
    {
        if (line.Contains(',')) { drawOrder = line.Split(',', StringSplitOptions.RemoveEmptyEntries); }
        else if (line.Length > 0)
        {
            if (board == null)
            {
                board = new int[5, 5];
                boardLine = 0;
            }
            var brickLineValues = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < brickLineValues.Length; i++)
            {
                board[boardLine.Value, i] = Int32.Parse(brickLineValues[i]);
            }

            if (boardLine == 4) _boards.Add(board);
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