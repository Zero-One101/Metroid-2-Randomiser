namespace Metroid2Randomiser.Areas
{
    internal class Area2 : Area
    {
        public Area2()
        {
            // 8 Missile Tanks
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0xDE90, "Area 2: Missile Tank west of High Jump - Top, Ceiling"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0xDE94, "Area 2: Missile Tank west of High Jump - Top, Floor"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0xDEBF, "Area 2: Missile Tank west of High Jump - Bottom"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0xDEC8, "Area 2: Missile Tank under Energy Tank"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0xD137, "Area 2: Missile Tank - Big Room, top left"));
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0xDE08, "Area 2: Missile Tank - Big Room, east of Arachnus")); // If this item doesn't update, try DE0E
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0xDE19, "Area 2: Missile Tank above water line west of Wave Beam"));
            Locations.Add(new Location(
                (i, il) => il.HasBombs(),
                0xDE2E, "Area 2: Missile Tank after water Alpha Metroid, below Wave Beam"));

            // 1 Energy Tank
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0xDECC, "Area 2: Energy Tank west of High Jump"));

            // High Jump Boots
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0xDED2, "Area 2: High Jump"));

            // Spring Ball
            Locations.Add(new Location(
                (i, il) => il.HasBombs() && (i.Name == "Spider Ball" || i.Name == "Space Jump" || il.HasSpiderBall() || il.HasSpaceJump()),
                0x9261, "Area 2: Arachnus"));

            // Varia Suit
            Locations.Add(new Location(
                (i, il) => il.HasBombs() && il.HasSpiderBall(),
                0xDDE5, "Area 2: Varia Suit"));

            // Wave Beam
            Locations.Add(new Location(
                (i, il) => il.HasSpiderBall() && il.HasBombs(),
                0xDE49, "Area 2: Wave Beam"));
        }
    }
}
