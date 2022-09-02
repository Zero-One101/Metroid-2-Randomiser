namespace Metroid2Randomiser.Areas
{
    internal class Area1 : Area
    {
        public Area1()
        {
            // 1 Energy Tank
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0xDD73, "Area 1: Energy Tank east of Bombs"));

            // 6 Missile Tanks
            // Missiles under Bombs
            Locations.Add(new Location(
                (i, items) => items.HasBombs(),
                0xDD8D, "Area 1: Missiles Under Bombs"));
            // Missile Tanks above Energy Tank
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0xDD2D, "Area 1: Missile Tank above Energy Tank - Left"));
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0xDD3B, "Area 1: Missile Tank above Energy Tank - Right"));
            // Missile Tanks west of Spider Ball
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0xDDA5, "Area 1: Missile Tank west of Spider Ball - Left"));
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0xDDB6, "Area 1: Missile Tank west of Spider Ball - Right"));
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0xDDB2, "Area 1: Missile Tank west of Spider Ball - Ceiling"));

            // Bombs
            // We aren't currently shuffling Bombs as it leads to a large generator failure rate. Looks like sphere 0 is practically this one check, and it must be bombs
            // Locations.Add(new Location(0xDD89, "Area 1: Bombs"));

            // Spider Ball
            Locations.Add(new Location(
                (i, items) => i.Name == "Spider Ball" || i.Name == "Space Jump" || items.HasSpiderBall() || items.HasSpaceJump(),
                0xDA24, "Area 1: Spider Ball"));

            // Ice Beam
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0xDDC9, "Area 1: Ice Beam"));
        }
    }
}
