using Metroid2Randomiser.Areas;
using System.Collections.Immutable;

namespace Metroid2Randomiser
{
    internal class World
    {
        private List<Area> areas;

        public World()
        {
            areas = new List<Area>()
            {
                new Area1(),
                new Area2()
            };
        }

        public ImmutableList<Location> GetAccessibleLocations(Item item, ImmutableList<Item> items)
        {
            var locs = areas.SelectMany(x => x.GetAccessibleLocations(item, items));
            return locs.ToImmutableList();
        }

        public ImmutableList<Location> GetAllLocations()
        {
            var locs = areas.SelectMany(x => x.Locations);
            return locs.ToImmutableList();
        }

        public bool PlaceItem(int area, Random random, Item item, ImmutableList<Item> items)
        {
            return areas[area].PlaceItem(random, item, items);
        }

        public void Reset()
        {
            foreach (var area in areas)
            {
                area.Reset();
            }
        }
    }
}
