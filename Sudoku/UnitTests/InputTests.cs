using Microsoft.VisualStudio.TestTools.UnitTesting;
using Board;
using System;

namespace Board.Tests
{
    [TestClass()]
    public class InputTests
    {
        [TestMethod()]
        public void ReadTest()
        {
            int boardSize = 4;
            GameBoard actual = new GameBoard(boardSize);
            GameBoard results = new GameBoard(boardSize);

            string path = @"C:\Users\Deverl\source\repos\Sudoku\SamplePuzzles\Input\Puzzle-4x4-0001.txt";

            Input input = new Input();

            actual = input.Read(path);
            results = input.Read(path);

            Assert.AreEqual(actual, results);


        }

        [TestMethod()]
        public void WriteTest()
        {
            int boardSize = 4;
            GameBoard gameBoard = new GameBoard(boardSize);

            string path = @"C:\Users\Deverl\source\repos\Sudoku\SamplePuzzles\Input\Puzzle-4x4-0001.txt";

            Input input = new Input();

            gameBoard = input.Read(path);

            input.Write(gameBoard);

            //Assert.
        }
    }
}