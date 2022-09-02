namespace Metroid2Randomiser
{
    internal abstract class Item
    {
        public string Name { get; protected set; } = String.Empty;
        public byte Value { get; protected set; } = 0xDB; // Intangible Metroid Egg item
    }
}
