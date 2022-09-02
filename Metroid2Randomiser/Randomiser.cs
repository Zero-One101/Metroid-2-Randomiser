using Metroid2Randomiser.Items;
using System.Collections.Immutable;

namespace Metroid2Randomiser
{
    internal class Randomiser
    {
        World world;
        List<Item> items;
        Random? random;
        string filePath;
        int seed;
        ROM? rom;

        public Randomiser(string filePath, int seed)
        {
            this.filePath = filePath;
            this.seed = seed;
            world = new World();

            // Populate list with Key Items
            // Bombs are excluded from this list. If Bombs are not in the vanilla location, generation regularly fails
            // This could be an issue with either Metroid II's structure, or my code
            // ...ok, fine, it's probably my code
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
            if (seed < 0)
            {
                seed = Environment.TickCount;
            }
            random = new Random(seed);
            this.seed = seed;

            var generated = false;

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
                        loc.SetItem(item);
                        Console.WriteLine($"{loc.Item.Name} placed at {loc.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"Could not place {item.Name}! Out of locations!");
                        generated = false;
                    }
                }
            } while (!generated);

            // Place "junk" items in the remaining locations
            List<Item> junk = Enumerable.Repeat((Item) new Missiles(), 22).ToList();
            junk.AddRange(Enumerable.Repeat(new EnergyTank(), 6));
            var junkLocs = world.GetAllLocations().Where(x => x.Item is EmptyItem).ToList();

            while (junk.Count > 0 && junkLocs.Count > 0)
            {
                var itemIdx = random.Next(junk.Count);
                var locIdx = random.Next(junkLocs.Count);
                var item = junk[itemIdx];
                junk.RemoveAt(itemIdx);
                var loc = junkLocs[locIdx];
                junkLocs.RemoveAt(locIdx);

                loc.SetItem(item);
                Console.WriteLine($"{loc.Item.Name} placed at {loc.Name}");
            }
            Console.WriteLine("Generated.");
        }

        public void CreateROM()
        {
            rom = new ROM(filePath, seed);
            rom.OpenROM();

            foreach (var loc in world.GetAllLocations())
            {
                rom.WriteByte(loc.Item.Value, loc.Offset);
            }

            rom.CloseROM();
        }
    }
}
