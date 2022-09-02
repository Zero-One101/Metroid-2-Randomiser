namespace Metroid2Randomiser
{
    internal class ROM
    {
        string romPath;
        string outputPath;
        FileStream? fs;
        int seed;

        public ROM(string filePath, int seed)
        {
            romPath = filePath;
            outputPath = Path.GetDirectoryName(romPath) + $"/MIIRando_{seed}.gb";
            this.seed = seed;
        }

        public void OpenROM()
        {
            File.Copy(romPath, outputPath);
            fs = new FileStream(outputPath, FileMode.Open);
        }

        public void CloseROM()
        {
            if (fs == null) return;
            fs.Close();
        }

        public void WriteByte(byte data, int offset)
        {
            if (fs == null) throw new InvalidOperationException("ROM must be opened by calling OpenROM()");

            fs.Position = offset;
            fs.WriteByte(data);
        }

        ~ROM()
        {
            if (fs != null)
            {
                fs.Close();
            }
        }
    }
}
