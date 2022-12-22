namespace AdventOfCode2022.December01
{
    internal class Elf
    {
        private readonly int _id;
        private readonly Backpack _backpack;

        public Elf(int id)
        {
            _id = id;
            _backpack = new Backpack();
        }

        public int Id => _id;
        public Backpack Backpack => _backpack;
        public int CaloriesCarried => _backpack.AllFoodItems.Select(m => m.Calories).Sum();
    }
}
