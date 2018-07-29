using System.Collections.Generic;

namespace SudokuSolver.Models
{
    public class Cell
    {
        public int CellValue { get; private set; }

        public List<int> PossibleValues { get; set; }

        public int SquareNumber { get; set; }

        public int RowNumber { get; set; }

        public int ColumnNumber { get; set;}

        public Cell(int rowNumber, int columnNumber, int squareNumber,int value = 0){
            this.CellValue = value;
            this.SquareNumber = squareNumber;
            this.RowNumber = rowNumber;
            this.ColumnNumber = columnNumber;

            if (value == 0)
                SetPossibleValues();
            else
                this.PossibleValues = new List<int>() { value };
        }

        public bool HasValue(){

            return (this.CellValue == 0) ? true : false;  
        }

        public override string ToString()
        {
            if (this.CellValue != 0)
            {
                return this.CellValue.ToString();
            }
            else{
                return "-";
            }
        }

        private void SetPossibleValues(){
            this.PossibleValues = new List<int> {1,2,3,4,5,6,7,8,9};
        }

        public void RemovePossibleValues (List<int> numbers)
        {
            this.PossibleValues.RemoveAll(v => numbers.Contains(v));
        }

        public bool CanSolve()
        {
            return this.PossibleValues.Count == 1 && this.CellValue == 0; 
        }

        public bool IsSolved()
        {
            return this.CellValue != 0;
        }

        public void SetCellValue(int value)
        {
            this.CellValue = value;
            this.PossibleValues = new List<int>(){ value }; 
        }
    }
}