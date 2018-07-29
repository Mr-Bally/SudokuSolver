using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.Models
{
    public class Grid
    {
        public List<Cell> Cells { get; set; }

        public Grid (List<Cell> cells)
        {
            this.Cells = cells;
        }

        public List<Cell> GetRowNumber (int index)
        {
            return this.Cells.Where(c => c.RowNumber == index).ToList();
        }

        public List<Cell> GetColumnNumber (int index)
        {
            return this.Cells.Where(c => c.ColumnNumber == index).ToList();
        }

        public List<Cell> GetSquareNumber (int index)
        {
            return this.Cells.Where(c => c.SquareNumber == index).ToList();
        }

        public override string ToString()
        {
            var stringToReturn = "";

            for(int x = 0; x <= 9; x++){
                var row = GetRowNumber(x);
                foreach(var cell in row)
                {
                    stringToReturn = stringToReturn + cell.ToString() + "\t";
                }
                stringToReturn = stringToReturn + "\n";
            }

            return stringToReturn;
        }
    }
}