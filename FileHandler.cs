using System.IO;

namespace gcj
{
    public class FileHandler
    {
        private static string path = Directory.GetCurrentDirectory();
        private static string absolutePath = "C:\\Users\\steff\\Documents\\Visual Studio 2015\\Projects\\gcj\\gcj\\";


        public static string ReadFromFile()
        {
            string filename = "file.txt";
            return File.ReadAllText(absolutePath + filename);
        }

        public static void WriteToFile(string text)
        {
            string filename = "CHANCE_THIS";
            File.WriteAllText(absolutePath + filename, text);
        }
    }
}