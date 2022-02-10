using System;
using System.IO;

namespace KataFizzBuzz
{
    public class FileReader : IFileReader
    {
        public int ReadNumberFromFile(string path)
        {
            if (!File.Exists(path))
                throw new Exception();

            var text = File.ReadAllText(path).Trim();
            if (!int.TryParse(text, out int result))
                throw new Exception();

            return result;
        }
    }
}