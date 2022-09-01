using Metroid2Randomiser.Items;
using System.Collections.Immutable;

namespace Metroid2Randomiser
{
    internal class Location
    {
        public Func<Item, ImmutableList<Item>, bool> CanAccess { get; } = (i, il) => true;
        public Item Item { get; set; } = new EmptyItem();
        public string Name { get; private set; }
        int offset;

        public Location(int offset, string name)
        {
            this.offset = offset;
            Name = name;
        }

        public Location(Func<Item, ImmutableList<Item>, bool> canAccess, int offset, string name) : this(offset, name)
        {
            CanAccess = canAccess;
        }
    }
}
