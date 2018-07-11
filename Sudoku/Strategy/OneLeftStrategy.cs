using Board;
using System.Collections.Generic;

namespace Strategy
{
    public class OneLeftStrategy : Template
    {
        public override void NoPossibleLeft(GameBoard board, int x, int y, int blx, int bly)
        {
            //blank
        }

        public override void OnlyOneLeft(GameBoard board, int x, int y, int blx, int bly)
        {
            Square[] blockSquares = board.block[blx*2+bly].sq;
            Square[] rowSquares = board.row[x].sq;
            Square[] colSquares = board.col[y].sq;
            Dictionary<string, string> possibilities = new Dictionary<string, string>();
            //Input numbers = new Input();
            string[] tokens = new string[4] { "A","B","C","D" };
           
            for (int i = 0; i < blockSquares.Length; i++)
            {
                possibilities.Add(tokens[i], tokens[i]);
            }
            
            foreach (var token in tokens)
            {
                for (int j = 0; j < blockSquares.Length; j++)
                {
                    if (possibilities.ContainsKey(token))
                    {
                        if (blockSquares[j].symbol.sym == possibilities[token] ||
                        rowSquares[j].symbol.sym == possibilities[token] || colSquares[j].symbol.sym == possibilities[token])
                            possibilities.Remove(token);
                    }
                }
                if (possibilities.Count == 1)
                {
                    foreach (var item in possibilities)
                    {
                        var t = item.Value;
                        board.row[x].sq[y].symbol.sym = t;
                        board.col[y].sq[x].symbol.sym = t;
                        board.block[blx * 2 + bly].sq[((x%2) * 2) + (y%2)].symbol.sym = t;
                    }
                }
            }
        }
            


        public override void Twins(GameBoard board, int x, int y, int b1x, int bly)
        {
            //blank
        }
    }
}
