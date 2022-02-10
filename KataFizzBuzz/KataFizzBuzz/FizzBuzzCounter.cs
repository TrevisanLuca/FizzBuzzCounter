using System.Collections.Generic;

namespace KataFizzBuzz
{
    public class FizzBuzzCounter : IFizzBuzzCounter
    {
        private readonly IFileReader _fileReader;
        public FizzBuzzCounter(IFileReader reader) => _fileReader = reader;
        public string Translate(int input)
        {
            var result = string.Empty;
            if (input % 3 == 0)
                result += "Fizz";
            if (input % 5 == 0)
                result += "Buzz";
            if (result.Length == 0)
                result = input.ToString();

            return result;
        }
        public string Translate2(int input) => input % 3 == 0 ? input % 5 == 0 ? "FizzBuzz" : "Fizz" : input % 5 == 0 ? "Buzz" : input.ToString();
        public List<string> Counter(int input)
        {
            var result = new List<string>();
            for (int i = 1; i < input + 1; i++)
                result.Add(Translate(i));

            return result;
        }
        public List<string> CounterFromFile(string path) => Counter(_fileReader.ReadNumberFromFile(path));
    }
}