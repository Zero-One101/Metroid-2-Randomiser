using System.Collections.Immutable;

namespace Metroid2Randomiser
{
    internal class World
    {
        private List<Area> areas;

        public World()
        {
            areas = new List<Area>();
        }

        public ImmutableList<Location> GetAccessibleLocations(IEnumerable<Item> items)
        {
            var locs = areas.SelectMany(x => x.GetAccessibleLocations(items));

            return locs.ToImmutableList();
        }
    }
}
