using System.Collections.Generic;
using System.Linq;
using SudokuSolver.Models;

namespace SudokuSolver.Service
{
    public class SolverService
    {
        public Grid Grid { get; set; }

        public SolverService(Grid grid)
        {
            this.Grid = grid;
        }

        public Grid Solve()
        {
            while(Grid.Cells.Any(c => c.IsSolved() == false))
            {
                RemoveTakenValues();                  
                CheckSets();
                
            }

            return Grid;
        }

        private void CheckSets()
        {
            foreach(var cell in Grid.Cells.Where(c => c.IsSolved() == false))
            {
                var row = Grid.Cells.Where(c => c.RowNumber == cell.RowNumber && c.ColumnNumber != cell.ColumnNumber).SelectMany(c => c.PossibleValues).ToList();

                CheckCollectionAgainstCell(cell, row);


                if (!cell.IsSolved())
                {
                    var column = Grid.Cells.Where(c => c.ColumnNumber == cell.ColumnNumber && c.RowNumber != cell.RowNumber).SelectMany(c => c.PossibleValues).ToList();
                    CheckCollectionAgainstCell(cell, column);
                }

                if (!cell.IsSolved())
                {
                    var square = Grid.Cells.Where(c => c.SquareNumber == cell.SquareNumber && !(c.RowNumber == cell.RowNumber && c.ColumnNumber == cell.ColumnNumber)).SelectMany(c => c.PossibleValues).ToList();
                    CheckCollectionAgainstCell(cell, square);
                }
            }
        }

        private void CheckCollectionAgainstCell(Cell cell, List<int> possibleValues)
        {
            foreach(var value in cell.PossibleValues)
            {
                if (!possibleValues.Contains(value) && !cell.IsSolved())
                {
                    cell.SetCellValue(value);
                }
            }
        }

        private void RemoveTakenValues()
        {
            foreach(var cell in Grid.Cells.Where(c => c.IsSolved() == false))
            {
                RemoveTakenValuesFromCell(cell, GetTakenValues(cell));

                if (cell.CanSolve())
                {
                    cell.SetCellValue(cell.PossibleValues.First());
                }
            }
        }

        private List<int> GetTakenValues(Cell cell)
        {
            var takenValues = Grid.Cells.Where(c => c.RowNumber == cell.RowNumber).Select(c => c.CellValue).ToList();
            takenValues.AddRange(Grid.Cells.Where(c => c.ColumnNumber == cell.ColumnNumber).Select(c => c.CellValue));
            takenValues.AddRange(Grid.Cells.Where(c => c.SquareNumber == cell.SquareNumber).Select(c => c.CellValue));

            return takenValues;
        }

        private void RemoveTakenValuesFromCell(Cell cell, List<int> takenValues)
        {
            cell.RemovePossibleValues(takenValues);
        }
    }
}