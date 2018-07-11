using System;
using Board;
using Strategy;

namespace Sudoku
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameBoard board;
            //string path = args[1];
            string path = @"C:\Users\Deverl\source\repos\Sudoku\SamplePuzzles\Input\Puzzle-4x4-0002.txt";
            Input input = new Input();

            board = input.Read(path);

            Solver solver = new Solver();
            solver.Solve(board);

            Console.WriteLine("SOLVED!");
            input.Write(board);

            Console.ReadLine();
        }
    }
}
