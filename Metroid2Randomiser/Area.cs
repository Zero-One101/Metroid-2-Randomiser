using Metroid2Randomiser.Items;
using System.Collections.Immutable;

namespace Metroid2Randomiser
{
    internal abstract class Area
    {
        public List<Location> Locations { get; protected set; }
        public Predicate<ImmutableList<Item>> CanAccess { get; protected set; } = i => true;

        public Area()
        {
            Locations = new List<Location>();
        }

        public ImmutableList<Location> GetAccessibleLocations(Item item, ImmutableList<Item> items)
        {
            if (!CanAccess(items))
            {
                return Enumerable.Empty<Location>().ToImmutableList();
            }

            var locs = new List<Location>();
            foreach (var loc in Locations)
            {
                if (loc.CanAccess(item, items) && loc.Item.Name == "Empty Item")
                {
                    locs.Add(loc);
                }
            }

            return locs.ToImmutableList();
        }

        /// <summary>
        /// Explicitly place an item in this area
        /// </summary>
        /// <param name="item">The item to place in the area</param>
        /// <param name="items">The player's assumed equipment</param>
        /// <returns>True if the item could be placed, else false</returns>
        public bool PlaceItem(Random random, Item item, ImmutableList<Item> items)
        {
            var locs = new List<Location>();
            foreach (var loc in Locations)
            {
                if (loc.CanAccess(item, items) && loc.Item.Name == "Empty Item")
                {
                    locs.Add(loc);
                }
            }

            if (locs.Count == 0)
            {
                Console.WriteLine($"Could not place {item.Name}! Out of locations!");
                return false;
            }
            else
            {
                var loc = locs[random.Next(locs.Count)];
                loc.Item = item;
                Console.WriteLine($"{loc.Item.Name} placed at {loc.Name}");
                return true;
            }
        }

        public void Reset()
        {
            foreach (var loc in Locations)
            {
                loc.Item = new EmptyItem();
            }
        }
    }
}
