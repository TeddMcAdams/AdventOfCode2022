namespace AdventOfCode2022
{
    public class Puzzle
    {
        private protected readonly IList<string> _exampleInput;
        private protected readonly IList<string> _mainInput;

        public Puzzle(string puzzleDate)
        {
            _exampleInput = LoadExampleInput(puzzleDate);
            _mainInput = LoadMainInput(puzzleDate);
        }

        private IList<string> LoadExampleInput(string puzzleDate)
        {
            return File.ReadLines($"PuzzleInputs/{puzzleDate}ExampleInput.txt").ToList();
        }

        private IList<string> LoadMainInput(string puzzleDate)
        {
            return File.ReadLines($"PuzzleInputs/{puzzleDate}MainInput.txt").ToList();
        }
    }
}
