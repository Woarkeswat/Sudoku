
namespace Board
{
    public class GameBoard
    {
        Row[] _row;
        Column[] _col;
        Block[] _block;
        int boardSize;

        public GameBoard(int boardSize)
        {
            _row = new Row[boardSize];
            _col = new Column[boardSize];
            _block = new Block[boardSize];

            for (int i = 0; i < boardSize; i++)
            {
                _row[i] = new Row(i, boardSize);
                _col[i] = new Column(i,boardSize);
                _block[i] = new Block(i, boardSize);
            }
        }

        public void Add(ref Square square)
        {
            int row = square.row.id;
            int column = square.col.id;
            int block = square.block.id;

            _row[row].Add(ref square);
            _col[column].Add(ref square);
            _block[block].Add(ref square);
        }

        public Square GetSquare(int rowNumber, int colNumber)
        {
            return _row[rowNumber].sq[colNumber];
        }

        public Row[] row { get { return _row; } set{ ; } }
        public Column[] col { get { return _col; } set { ; } }
        public Block[] block { get { return _block; } set { ; } }
        public int size { get { return boardSize; } set { boardSize = value; } }
    }
}
