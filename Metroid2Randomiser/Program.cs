namespace Metroid2Randomiser
{
    public class Program
    {
        private static Randomiser? randomiser;
        public static void Main(string[] args)
        {
            randomiser = new Randomiser();
            randomiser.Generate(-1);
        }
    }
}