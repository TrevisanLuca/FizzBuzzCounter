using System.Collections.Generic;
namespace KataFizzBuzz
{
    public interface IFizzBuzzCounter
    {
        string Translate(int input);
        //string Translate2(int input);
        List<string> Counter(int input);
        List<string> CounterFromFile(string path);
    }
}