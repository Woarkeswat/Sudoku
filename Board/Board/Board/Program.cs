using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = 16;     // The dimension of the sudoku board
            int BD = (int)System.Math.Sqrt(D);  // The dimension of blocks in the board

            int[,] board = new int[D,D];

            int I, J;   // the coordinates of a cell on the board
            int bi, bj; // the coordinates of a block on the board
            int i, j;   // the coordinates of a cell on a block

            // fill the board with unique numbers
            i = 0;
            for (int t = 0; i < D; i++)
            {
                for (j = 0; j < D; j++)
                {
                    board[i,j] = t++;
                }
            }

            // output the initial board
            for (i = 0; i < D; i++)
            {
                for (j = 0; j < D; j++)
                {
                    Console.Write("{0,3} ", board[i,j]);
                    if (j % BD == BD - 1 && j != D - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();

                if (i % BD == BD - 1 && i != D - 1)
                {
                    for (j = 0; j < D; j++)
                    {
                        Console.Write("----");
                        if (j % BD == BD - 1 && j != D - 1)
                        {
                            Console.Write("+");
                        }
                    }
                    Console.WriteLine();
                }
            }

            // print out the cells in the block at (1,2)
            bi = 1;
            bj = 2;

            Console.WriteLine("\nCells in the block at (" + bi + "," + bj + "):");
            for (i = 0; i < BD; i++)
            {
                for (j = 0; j < BD; j++)
                {
                    Console.Write("{0,3} ", board[bi * BD + i,bj * BD + j]);
                }
                Console.WriteLine();
            }

            // find out the block coordinates of the cell (10,8)
            I = 12;
            J = 10;

            Console.WriteLine("\nThe cell at (" + I + "," + J + ") is: " + board[I,J]);
            Console.WriteLine("The block is (" + (int)(I/BD) + "," + (int)(J/BD) + ").");
            Console.WriteLine("The cell is at (" + I%BD + "," + J%BD + ") in that block.");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
