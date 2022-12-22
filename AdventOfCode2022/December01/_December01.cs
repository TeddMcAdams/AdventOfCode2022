namespace AdventOfCode2022.December01
{
    public class December01Puzzle : Puzzle, IPuzzle
    {
        private IList<Elf> _elves;

        private IList<string> _puzzleInput;
        private string _partOneResult;
        private string _partTwoResult;

        public December01Puzzle(bool useExampleInput) : base(nameof(December01Puzzle))
        {
            _elves = new List<Elf>();
            
            _puzzleInput = useExampleInput ? _exampleInput : _mainInput;
            _partOneResult = PartOne();
            _partTwoResult = PartTwo();
        }

        public string PartOneResult()
        {
            return _partOneResult;
        }

        public string PartTwoResult()
        {
            return _partTwoResult;
        }

        private string PartOne()
        {
            int elfCounter = 1;
            int elfFoodCounter = 1;
            Elf? elfToAdd = null;

            foreach (string line in _puzzleInput)
            {
                elfToAdd ??= new Elf(elfCounter);

                if (IsNewElf(line))
                {
                    _elves.Add(elfToAdd);
                    elfCounter++;
                    elfFoodCounter = 1;
                    elfToAdd = null;
                    continue;
                }
                else
                {
                    var newFoodItem = new FoodItem(int.Parse($"{elfCounter}{elfFoodCounter}"), $"{Guid.NewGuid()}", int.Parse(line));

                    elfToAdd.Backpack.AddFoodItem(newFoodItem);
                    elfFoodCounter++;
                }
            }

            if (elfToAdd is not null) _elves.Add(elfToAdd);

            Elf elfCarryingMostCalories = ElvesOrderedByMostCaloriesCarried().First();

            return $"{elfCarryingMostCalories.CaloriesCarried}";
        }

        private string PartTwo()
        {
            IEnumerable<Elf> topThreeElvesCarryingMostCalories = ElvesOrderedByMostCaloriesCarried().Take(3);

            return $"{topThreeElvesCarryingMostCalories.Select(_ => _.CaloriesCarried).Sum()}";
        }

        private static bool IsNewElf(string line)
        {
            return string.IsNullOrWhiteSpace(line);
        }

        private IEnumerable<Elf> ElvesOrderedByMostCaloriesCarried()
        {
            return _elves.OrderByDescending(_ => _.CaloriesCarried);
        }
    }
}
