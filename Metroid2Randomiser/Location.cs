namespace Metroid2Randomiser
{
    internal class Location
    {
        public Predicate<IEnumerable<Item>> CanAccess { get; } = i => true;
        public Item? Item { get; set; } = null;
        int offset;

        public Location(int offset)
        {
            this.offset = offset;
        }

        public Location(Predicate<IEnumerable<Item>> canAccess, int offset) : this(offset)
        {
            CanAccess = canAccess;
        }
    }
}
