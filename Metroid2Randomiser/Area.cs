using System.Collections.Immutable;

namespace Metroid2Randomiser
{
    internal abstract class Area
    {
        private List<Location> locations;
        public Predicate<IEnumerable<Item>> CanAccess { get; } = i => true;

        public Area()
        {
            locations = new List<Location>();
        }

        public ImmutableList<Location> GetAccessibleLocations(IEnumerable<Item> items)
        {
            if (!CanAccess(items))
            {
                return Enumerable.Empty<Location>().ToImmutableList();
            }

            var locs = new List<Location>();
            foreach (var loc in locations)
            {
                if (loc.CanAccess(items))
                {
                    locations.Add(loc);
                }
            }

            return locs.ToImmutableList();
        }
    }
}
