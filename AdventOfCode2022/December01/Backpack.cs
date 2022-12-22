namespace AdventOfCode2022.December01
{
    internal class Backpack
    {
        private List<FoodItem> _foodItems;

        public Backpack()
        {
            _foodItems = new List<FoodItem>();
        }

        public IList<FoodItem> AllFoodItems => _foodItems;

        internal void AddFoodItem(FoodItem foodItem)
        {
            _foodItems.Add(foodItem);
        }

        internal void RemoveFoodItem(int foodItemId)
        {
            _foodItems.RemoveAll(m => m.Id == foodItemId);
        }
    }
}
