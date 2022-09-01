using Metroid2Randomiser.Items;
using System.Collections.Immutable;

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
            items = new List<Item>()
            {
                new SpiderBall(),
                new SpaceJump(),
                new HighJump(),
                new IceBeam(),
                new PlasmaBeam(),
                new ScrewAttack(),
                new SpazerBeam(),
                new SpringBall(),
                new VariaSuit(),
                new WaveBeam()
            };
        }

        public void Generate(int seed)
        {
            random = seed < 0 ? new Random() : new Random(seed);
            var generated = false;
            //world.PlaceItem(0, random, new Bomb(), Enumerable.Empty<Item>().ToImmutableList());

            // Place key items first
            do
            {
                generated = true;
                world.Reset();

                var keyItems = new List<Item>(items);
                while (keyItems.Count > 0)
                {
                    var idx = random.Next(keyItems.Count);
                    var item = keyItems[idx];
                    keyItems.RemoveAt(idx);

                    var locs = world.GetAccessibleLocations(item, keyItems.ToImmutableList());

                    if (!locs.IsEmpty)
                    {
                        var loc = locs[random.Next(locs.Count)];
                        loc.Item = item;
                        Console.WriteLine($"{loc.Item.Name} placed at {loc.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"Could not place {item.Name}! Out of locations!");
                        generated = false;
                    }
                }
            } while (!generated);

            Console.WriteLine("Generated.");
        }

        public void PrintLocations()
        {
            foreach (var loc in world.GetAllLocations())
            {
                Console.WriteLine($"{loc.Item.Name} placed at {loc.Name}");
            }
        }
    }
}
