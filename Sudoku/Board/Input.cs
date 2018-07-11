using System.IO;
using System;

namespace Board
{
    public class Input
    {
        public Symbol[] tokens;
        private int blockSize;

        public GameBoard Read(string path)
        {
            
            int counter = 0;
            GameBoard board = null;
            try
            {
                StreamReader streamReader = new StreamReader(path);

                string size = streamReader.ReadLine();
                int boardSize;
                int.TryParse(size, out boardSize);
                blockSize = (int)Math.Sqrt(boardSize);
                board = new GameBoard(boardSize);

                string values = streamReader.ReadLine();
                tokens = new Symbol[boardSize];
                string[] symbols = values.Split(' ');
                foreach (var symbol in symbols)
                {
                    tokens[counter++] = new Symbol(symbol); 
                }
                
                for (int i = 0; i < boardSize; i++)
                {
                    int j = 0;
                    string lyne = streamReader.ReadLine();
                    string[] syms = lyne.Split(' ');
                    Square s;
                    foreach (string sym in syms)
                    {
                        s = new Square(sym, i, j, ((i/blockSize) * blockSize) + (j/blockSize));
                        board.Add(ref s);
                        s = null;
                        j++;
                    }
                }
            }
            catch(Exception e)
            {
                Console.Write(e.StackTrace);
            }
            return board;
        }
        public void Write(GameBoard board)
        {
            for (int i = 0; i < board.row.Length; i++)
            {
                for (int j = 0; j < board.col.Length; j++)
                {
                    Console.Write(board.GetSquare(i, j).symbol.sym);
                }
                Console.Write("\n");
            }
        }

        public int blockDimensions { get { return blockSize; } set { ; }   }
    }
}
