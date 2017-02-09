using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private const string _fileName = "words.txt";

        static void Main(string[] args)
        {
            var fileReader = new FileReaderService(new FileReaderRepository(), _fileName);

            var wordCalculator = new WordCalculatorService(new WordCalculatorRepository());

            var words = fileReader.ReadLines();

            foreach (var word in words)
            {
                var wordSum = wordCalculator.CalculateWordSum(word);

                if (wordSum == 100)
                {
                    Console.WriteLine(wordSum);
                }
            }
        }
    }
}
