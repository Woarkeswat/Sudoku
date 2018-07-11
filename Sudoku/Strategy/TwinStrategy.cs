using Board;

namespace Strategy
{
    public class TwinStrategy : Template
    {
        public override void NoPossibleLeft(GameBoard board, int x, int y, int blx, int bly)
        {
            //blank
        }

        public override void OnlyOneLeft(GameBoard board, int x, int y, int blx, int bly)
        {
            //blank
        }

        public override void Twins(GameBoard board, int x, int y, int blx, int bly)
        {
            Square[] blockSquares = board.block[x].sq;
            Square[] rowSquares = board.row[x].sq;
            Square[] colSquares = board.col[y].sq;
            string[] possibilities = new string[board.block.Length];

            for (int i = 0; i < possibilities.Length; i++)
            {
                possibilities[i] = blockSquares[i].symbol.sym;
            }
        }
    }
}
