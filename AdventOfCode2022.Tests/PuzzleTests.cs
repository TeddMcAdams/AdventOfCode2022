namespace AdventOfCode2022.Tests
{
    public class PuzzleTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public PuzzleTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void December01(bool examplePuzzleInput)
        {
            // Arrange
            IPuzzle _puzzle = new December01Puzzle(examplePuzzleInput);

            string partOneExpected = examplePuzzleInput ? "24000" : "67658";
            string partTwoExpected = examplePuzzleInput ? "45000" : "200158";

            // Act
            string partOneActual = _puzzle.PartOneResult();
            string partTwoActual = _puzzle.PartTwoResult();

            // Assert
            Assert.Equal(partOneExpected, partOneActual);
            Assert.Equal(partTwoExpected, partTwoActual);

            LogResult(partOneExpected, partOneActual, partTwoExpected, partTwoActual);
        }

        private void LogResult(string partOneExpected, string partOneActual, string partTwoExpected, string partTwoActual)
        {
            _testOutputHelper.WriteLine("\nPart One\n¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
            _testOutputHelper.WriteLine($"Expected: {partOneExpected} Actual: {partOneActual}");
            _testOutputHelper.WriteLine("");
            _testOutputHelper.WriteLine("\nPart Two\n¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
            _testOutputHelper.WriteLine($"Expected: {partTwoExpected} Actual: {partTwoActual}");
        }
    }
}
