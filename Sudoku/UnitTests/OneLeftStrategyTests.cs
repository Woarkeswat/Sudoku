using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy;
using Board;
using System;

namespace Strategy.Tests
{
    [TestClass()]
    public class OneLeftStrategyTests
    {
        [TestMethod()]
        public void OnlyOneLeftTest()
        {
            int boardSize = 4;
            GameBoard gameBoard = new GameBoard(boardSize);
            Template executor = new OneLeftStrategy();
            int blockSize = (int)Math.Sqrt(boardSize);
            int x = 3;
            int y = 2;
            int blx = x/blockSize;
            int bly = y/blockSize;
            string path = @"C:\Users\Deverl\source\repos\Sudoku\SamplePuzzles\Input\Puzzle-4x4-0001.txt";

            Input input = new Input();
            gameBoard = input.Read(path);
            executor.OnlyOneLeft(gameBoard, x, y, blx, bly);

            //Assert.

        }
    }
}