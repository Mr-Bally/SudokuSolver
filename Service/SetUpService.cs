using System.Collections.Generic;
using SudokuSolver.Models;

namespace SudokuSolver.Service
{
    // JSON file converter?
    public class SetUpService
    {
        public Grid InitialiseGrid()
        {
            var cells = GetCells();
            var grid = new Grid(cells);

            return grid;
        }

        private List<Cell> GetCells()
        {
            /*return new List<Cell>()
            {
                // Row number, Column number, Square number, value
                //Row one
                new Cell(0, 0, 0, 6),
                new Cell(0, 1, 0, 0),
                new Cell(0, 2, 0, 0),
                new Cell(0, 3, 1, 2),
                new Cell(0, 4, 1, 8),
                new Cell(0, 5, 1, 0),
                new Cell(0, 6, 2, 9),
                new Cell(0, 7, 2, 0),
                new Cell(0, 8, 2, 0),
                //Row two
                new Cell(1, 0, 0, 0),
                new Cell(1, 1, 0, 4),
                new Cell(1, 2, 0, 7),
                new Cell(1, 3, 1, 1),
                new Cell(1, 4, 1, 0),
                new Cell(1, 5, 1, 0),
                new Cell(1, 6, 2, 2),
                new Cell(1, 7, 2, 0),
                new Cell(1, 8, 2, 0),
                //Row three
                new Cell(2, 0, 0, 9),
                new Cell(2, 1, 0, 0),
                new Cell(2, 2, 0, 0),
                new Cell(2, 3, 1, 0),
                new Cell(2, 4, 1, 6),
                new Cell(2, 5, 1, 0),
                new Cell(2, 6, 2, 0),
                new Cell(2, 7, 2, 7),
                new Cell(2, 8, 2, 8),
                //Row four
                new Cell(3, 0, 3, 0),
                new Cell(3, 1, 3, 3),
                new Cell(3, 2, 3, 0),
                new Cell(3, 3, 4, 6),
                new Cell(3, 4, 4, 9),
                new Cell(3, 5, 4, 0),
                new Cell(3, 6, 5, 0),
                new Cell(3, 7, 5, 0),
                new Cell(3, 8, 5, 5),
                //Row five
                new Cell(4, 0, 3, 0),
                new Cell(4, 1, 3, 0),
                new Cell(4, 2, 3, 0),
                new Cell(4, 3, 4, 5),
                new Cell(4, 4, 4, 0),
                new Cell(4, 5, 4, 2),
                new Cell(4, 6, 5, 3),
                new Cell(4, 7, 5, 0),
                new Cell(4, 8, 5, 0),
                //Row six
                new Cell(5, 0, 3, 5),
                new Cell(5, 1, 3, 0),
                new Cell(5, 2, 3, 2),
                new Cell(5, 3, 4, 0),
                new Cell(5, 4, 4, 0),
                new Cell(5, 5, 4, 0),
                new Cell(5, 6, 5, 0),
                new Cell(5, 7, 5, 4),
                new Cell(5, 8, 5, 1),
                //Row seven
                new Cell(6, 0, 6, 0),
                new Cell(6, 1, 6, 8),
                new Cell(6, 2, 6, 1),
                new Cell(6, 3, 7, 0),
                new Cell(6, 4, 7, 0),
                new Cell(6, 5, 7, 0),
                new Cell(6, 6, 8, 7),
                new Cell(6, 7, 8, 0),
                new Cell(6, 8, 8, 9),
                //Row eight
                new Cell(7, 0, 6, 2),
                new Cell(7, 1, 6, 0),
                new Cell(7, 2, 6, 0),
                new Cell(7, 3, 7, 0),
                new Cell(7, 4, 7, 1),
                new Cell(7, 5, 7, 6),
                new Cell(7, 6, 8, 0),
                new Cell(7, 7, 8, 0),
                new Cell(7, 8, 8, 0),
                // Row nine
                new Cell(8, 0, 6, 0),
                new Cell(8, 1, 6, 0),
                new Cell(8, 2, 6, 6),
                new Cell(8, 3, 7, 9),
                new Cell(8, 4, 7, 3),
                new Cell(8, 5, 7, 0),
                new Cell(8, 6, 8, 0),
                new Cell(8, 7, 8, 1),
                new Cell(8, 8, 8, 0),
            };*/
            
            // Hard
            return new List<Cell>()
            {
                // Row number, Column number, Square number, value
                 
                //Row one
                new Cell(0, 0, 0, 0),
                new Cell(0, 1, 0, 0),
                new Cell(0, 2, 0, 0),
                new Cell(0, 3, 1, 7),
                new Cell(0, 4, 1, 0),
                new Cell(0, 5, 1, 0),
                new Cell(0, 6, 2, 0),
                new Cell(0, 7, 2, 6),
                new Cell(0, 8, 2, 0),
                //Row two
                new Cell(1, 0, 0, 2),
                new Cell(1, 1, 0, 0),
                new Cell(1, 2, 0, 0),
                new Cell(1, 3, 1, 4),
                new Cell(1, 4, 1, 0),
                new Cell(1, 5, 1, 0),
                new Cell(1, 6, 2, 0),
                new Cell(1, 7, 2, 5),
                new Cell(1, 8, 2, 0),
                //Row three
                new Cell(2, 0, 0, 0),
                new Cell(2, 1, 0, 8),
                new Cell(2, 2, 0, 4),
                new Cell(2, 3, 1, 0),
                new Cell(2, 4, 1, 3),
                new Cell(2, 5, 1, 0),
                new Cell(2, 6, 2, 7),
                new Cell(2, 7, 2, 0),
                new Cell(2, 8, 2, 2),
                //Row four
                new Cell(3, 0, 3, 0),
                new Cell(3, 1, 3, 0),
                new Cell(3, 2, 3, 2),
                new Cell(3, 3, 4, 0),
                new Cell(3, 4, 4, 0),
                new Cell(3, 5, 4, 0),
                new Cell(3, 6, 5, 0),
                new Cell(3, 7, 5, 7),
                new Cell(3, 8, 5, 9),
                //Row five
                new Cell(4, 0, 3, 0),
                new Cell(4, 1, 3, 0),
                new Cell(4, 2, 3, 0),
                new Cell(4, 3, 4, 0),
                new Cell(4, 4, 4, 4),
                new Cell(4, 5, 4, 0),
                new Cell(4, 6, 5, 0),
                new Cell(4, 7, 5, 0),
                new Cell(4, 8, 5, 0),
                //Row six
                new Cell(5, 0, 3, 1),
                new Cell(5, 1, 3, 3),
                new Cell(5, 2, 3, 0),
                new Cell(5, 3, 4, 0),
                new Cell(5, 4, 4, 0),
                new Cell(5, 5, 4, 0),
                new Cell(5, 6, 5, 4),
                new Cell(5, 7, 5, 0),
                new Cell(5, 8, 5, 0),
                //Row seven
                new Cell(6, 0, 6, 6),
                new Cell(6, 1, 6, 0),
                new Cell(6, 2, 6, 9),
                new Cell(6, 3, 7, 0),
                new Cell(6, 4, 7, 2),
                new Cell(6, 5, 7, 0),
                new Cell(6, 6, 8, 1),
                new Cell(6, 7, 8, 3),
                new Cell(6, 8, 8, 0),
                //Row eight
                new Cell(7, 0, 6, 0),
                new Cell(7, 1, 6, 4),
                new Cell(7, 2, 6, 0),
                new Cell(7, 3, 7, 0),
                new Cell(7, 4, 7, 0),
                new Cell(7, 5, 7, 6),
                new Cell(7, 6, 8, 0),
                new Cell(7, 7, 8, 0),
                new Cell(7, 8, 8, 5),
                // Row nine
                new Cell(8, 0, 6, 0),
                new Cell(8, 1, 6, 2),
                new Cell(8, 2, 6, 0),
                new Cell(8, 3, 7, 0),
                new Cell(8, 4, 7, 0),
                new Cell(8, 5, 7, 5),
                new Cell(8, 6, 8, 0),
                new Cell(8, 7, 8, 0),
                new Cell(8, 8, 8, 0),
            };
        }
    }
}