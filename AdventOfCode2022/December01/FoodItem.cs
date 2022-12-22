namespace AdventOfCode2022.December01
{
    internal class FoodItem
    {
        private readonly int _id;
        private readonly string _name;
        private readonly int _calories;

        public FoodItem(int id, string name, int calories)
        {
            _id = id;
            _name = name;
            _calories = calories;
        }

        public int Id => _id;
        public string Name => _name;
        public int Calories => _calories;
    }
}
