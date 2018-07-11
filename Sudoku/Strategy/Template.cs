using Board;

namespace Strategy
{
    public abstract class Template
    {
        public void Solve(GameBoard board, int x, int y, int blockX, int blockY)
        {
            OnlyOneLeft(board, x, y, blockX, blockY);
            NoPossibleLeft(board, x, y, blockX, blockY);
            Twins(board, x, y, blockX, blockY);

        }

        public abstract void OnlyOneLeft(GameBoard board, int x, int y, int blockX, int blockY);
        public abstract void NoPossibleLeft(GameBoard board, int x, int y, int blockX, int blockY);
        public abstract void Twins(GameBoard board, int x, int y, int blockX, int blockY);
    }
}
