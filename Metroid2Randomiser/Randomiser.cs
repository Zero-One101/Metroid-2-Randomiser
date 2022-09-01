namespace Metroid2Randomiser
{
    internal class Randomiser
    {
        World world;
        List<Item> items;
        Random? random;

        public Randomiser()
        {
            world = new World();

            // Populate list with Key Items
            items = new List<Item>();
        }

        public void Generate(int seed)
        {
            random = seed < 0 ? new Random() : new Random(seed);

            // Place key items first
            while (items.Count > 0)
            {
                var idx = random.Next(items.Count);
                var item = items[idx];
                items.RemoveAt(idx);

                var locs = world.GetAccessibleLocations(items);
                locs[random.Next(locs.Count)].Item = item;
            }
        }
    }
}
