using GeneticSharp;
using Sudoku.Shared;

namespace Sudoku.GeneticAlgorithmSolver
{
    public class SudokuFitness : IFitness
    {
        private SudokuGrid _sudokuToSolve;

        public SudokuFitness(SudokuGrid gridToSolve)
        {
            _sudokuToSolve = gridToSolve;
        }

        public double Evaluate(SudokuChromosome sudokuChromosome)
        {
            double toReturn = _sudokuToSolve.NbErrors(_sudokuToSolve);

            return -toReturn;
        }

        public double Evaluate(IChromosome chromosome)
        {
            return Evaluate((SudokuChromosome)chromosome);
        }


    }
}
