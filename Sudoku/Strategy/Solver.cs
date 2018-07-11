using System;
using Board;

namespace Strategy
{
    public class Solver
    {
        private Template strategy1 = new OneLeftStrategy();
        private Template strategy2 = new TwinStrategy();
        private Input input = new Input();
        private int blockDimension = 2;
    
        public GameBoard Solve(GameBoard board)
        {
            for(int i = 0; i < board.row.Length; i++)
            {
                for(int j = 0; j < board.col.Length; j++)
                {
                    if(board.GetSquare(i, j).symbol.sym.Equals("-"))
                    {
                        strategy1.OnlyOneLeft(board, i, j, i/blockDimension, j/blockDimension);
                        strategy2.Twins(board, i, j, i/blockDimension, j/blockDimension);
                    }
                }
            }
            return board;
        }
    }
}
