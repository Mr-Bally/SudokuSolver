using System;
using System.Collections.Generic;
using SudokuSolver.Models;
using SudokuSolver.Service;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell test = new Cell(3, 5, 4, 0);
            var setUp = new SetUpService();
            var grid = setUp.InitialiseGrid();
            
            var solver = new SolverService(grid);
            
            Console.WriteLine("Sudoku solver\n");
            Console.WriteLine("Grid to be solved\n");
            Console.WriteLine(grid.ToString());
            
            grid = solver.Solve();
            
            Console.WriteLine("\nGrid solved\n");
            Console.WriteLine(grid.ToString());
        }
    }
}
