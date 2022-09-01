namespace Metroid2Randomiser.Areas
{
    internal class Area1 : Area
    {
        public Area1()
        {
            // 1 Energy Tank
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0x53, "Area 1: Energy Tank east of Bombs"));

            // 6 Missile Tanks
            // Missiles under Bombs
            Locations.Add(new Location(
                (i, items) => items.HasBombs(),
                0x53, "Area 1: Missiles Under Bombs"));
            // Missile Tanks above Energy Tank
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0x53, "Area 1: Missile Tank above Energy Tank"));
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0x53, "Area 1: Missile Tank above Energy Tank"));
            // Missile Tanks west of Spider Ball
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0x53, "Area 1: Missile Tank west of Spider Ball"));
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0x53, "Area 1: Missile Tank west of Spider Ball"));
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0x53, "Area 1: Missile Tank west of Spider Ball"));

            // Bombs
            //Locations.Add(new Location(0x53, "Area 1: Bombs"));

            // Spider Ball
            Locations.Add(new Location(
                (i, items) => i.Name == "Spider Ball" || i.Name == "Space Jump" || items.HasSpiderBall() || items.HasSpaceJump(),
                0x53, "Area 1: Spider Ball"));

            // Ice Beam
            Locations.Add(new Location(
                (i, items) => items.HasBombs() || items.HasSpiderBall() || items.HasSpaceJump(),
                0x53, "Area 1: Ice Beam"));
        }
    }
}
