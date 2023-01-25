using Sudoku.Shared;

namespace SolverCSPLea
{
    public class CSPSolver : ISudokuSolver
    {
        //test
        public SudokuGrid Solve(SudokuGrid s)
        {
            return s.CloneSudoku();
        }
    }
}