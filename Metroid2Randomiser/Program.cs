namespace Metroid2Randomiser
{
    public class Program
    {
        private static Randomiser? randomiser;
        public static void Main(string[] args)
        {
            var filePath = args[0];
            var seed = int.Parse(args[1]);
            randomiser = new Randomiser(filePath, seed);
            randomiser.Generate(-1);
            randomiser.CreateROM();

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}