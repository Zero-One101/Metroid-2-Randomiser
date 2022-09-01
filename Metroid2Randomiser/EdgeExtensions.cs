using System.Collections.Immutable;

namespace Metroid2Randomiser
{
    internal static class EdgeExtensions
    {
        //public static bool HasBombs(this ImmutableList<Item> il) => il.Any(x => x.Name == "Bombs");
        public static bool HasBombs(this ImmutableList<Item> _) => true;
        public static bool HasHighJump(this ImmutableList<Item> il) => il.Any(x => x.Name == "High Jump Boots");
        public static bool HasIceBeam(this ImmutableList<Item> il) => il.Any(x => x.Name == "Ice Beam");
        public static bool HasPlasmaBeam(this ImmutableList<Item> il) => il.Any(x => x.Name == "Plasma Beam");
        public static bool HasScrewAttack(this ImmutableList<Item> il) => il.Any(x => x.Name == "Screw Attack");
        public static bool HasSpaceJump(this ImmutableList<Item> il) => il.Any(x => x.Name == "Space Jump");
        public static bool HasSpazerBeam(this ImmutableList<Item> il) => il.Any(x => x.Name == "Spazer Beam");
        public static bool HasSpiderBall(this ImmutableList<Item> il) => il.Any(x => x.Name == "Spider Ball");
        public static bool HasSpringBall(this ImmutableList<Item> il) => il.Any(x => x.Name == "Spring Ball");
        public static bool HasVaria(this ImmutableList<Item> il) => il.Any(x => x.Name == "Varia Suit");
        public static bool HasWaveBeam(this ImmutableList<Item> il) => il.Any(x => x.Name == "Wave Beam");
    }
}
