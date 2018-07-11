
namespace Board
{
    public class Square
    {
        private Symbol _symbol;
        private Row _row;
        private Column _col;
        private Block _block;
        private int _boardSize = 0;

        public Square(string symbol, int row, int col, int block, int boardSize)
        {
            _symbol = new Symbol (symbol);
            _row = new Row (row, boardSize);
            _col = new Column (col, boardSize);
            _block = new Block (block, boardSize);
            _boardSize = boardSize;
        }

        public Square(string symbol, int row, int col, int block)
        {
            _symbol = new Symbol(symbol);
            _row = new Row(row, _boardSize);
            _col = new Column(col, _boardSize);
            _block = new Block(block, _boardSize);
        }
        
        public Symbol symbol { get { return _symbol; } set { _symbol = value; } }
        public Row row { get { return _row; } set { _row = value; } }
        public Column col { get { return _col; } set { _col = value; } }
        public Block block { get { return _block; } set { _block = value; } }
    }
}
