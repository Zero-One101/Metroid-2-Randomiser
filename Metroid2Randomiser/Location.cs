using Metroid2Randomiser.Items;
using System.Collections.Immutable;

namespace Metroid2Randomiser
{
    internal class Location
    {
        public Func<Item, ImmutableList<Item>, bool> CanAccess { get; } = (i, il) => true;
        public Item Item { get; protected set; } = new EmptyItem();
        public string Name { get; private set; }
        public int Offset { get; protected set; }

        private bool IsArachnus() => Offset == 0x9261;

        public Location(int offset, string name)
        {
            this.Offset = offset;
            Name = name;
        }

        public Location(Func<Item, ImmutableList<Item>, bool> canAccess, int offset, string name) : this(offset, name)
        {
            CanAccess = canAccess;
        }

        public void SetItem(Item item)
        {
            if (IsArachnus())
            {
                // TODO: Properly handle Arachnus' drop
                // For now, just make it Spring Ball as normal
                Item = new SpringBall();
                return;
            }

            Item = item;
        }
    }
}
