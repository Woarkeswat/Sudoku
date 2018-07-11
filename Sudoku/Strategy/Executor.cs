using Board;

namespace Strategy
{
    public abstract class Executor
    {
        public void Solve(GameBoard board, int x, int y, int block)
        {
            OnlyOneLeft(board, x, y, block);
            NoPossibleLeft(board, x, y, block);
            Twins(board, x, y, block);

        }

        public abstract void OnlyOneLeft(GameBoard board, int x, int y, int block);
        public abstract void NoPossibleLeft(GameBoard board, int x, int y, int block);
        public abstract void Twins(GameBoard board, int x, int y, int block);
    }
}
