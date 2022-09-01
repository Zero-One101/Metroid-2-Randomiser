namespace Metroid2Randomiser
{
    internal abstract class Item
    {
        public string Name { get; protected set; } = String.Empty;
        public byte value { get; protected set; }
    }
}
