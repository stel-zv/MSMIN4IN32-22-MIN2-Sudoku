using Sudoku.Shared;

namespace SolverCSPLea
{
    public class CSPSolver : ISudokuSolver
    {
        public SudokuGrid Solve(SudokuGrid s)
        {
            return s.CloneSudoku();
        }
    }
}