namespace Metroid2Randomiser.Areas
{
    internal class Area2 : Area
    {
        public Area2()
        {
            // 8 Missile Tanks
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0x53, "Area 2: Missile Tank west of High Jump"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0x53, "Area 2: Missile Tank west of High Jump"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0x53, "Area 2: Missile Tank west of High Jump"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0x53, "Area 2: Missile Tank under Energy Tank"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0x53, "Area 2: Missile Tank - Big Room, top left"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0x53, "Area 2: Missile Tank - Big Room, east of Arachnus"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0x53, "Area 2: Missile Tank above water line west of Wave Beam"));
            Locations.Add(new Location(
                (i, il) => il.HasBombs(),
                0x53, "Area 2: Missile Tank after water Alpha Metroid, below Wave Beam"));

            // 1 Energy Tank
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0x53, "Area 2: Energy Tank west of High Jump"));

            // High Jump Boots
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0x53, "Area 2: High Jump"));

            // Spring Ball
            Locations.Add(new Location(
                (i, il) => il.HasBombs() && (i.Name == "Spider Ball" || i.Name == "Space Jump" || il.HasSpiderBall() || il.HasSpaceJump()),
                0x53, "Area 2: Arachnus"));

            // Varia Suit
            Locations.Add(new Location(
                (i, il) => il.HasBombs() && il.HasSpiderBall(),
                0x53, "Area 2: Varia Suit"));

            // Wave Beam
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0x53, "Area 2: Wave Beam"));
        }
    }
}
