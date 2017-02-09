using DollarWords.Services.WordCalculatorService;
using System;
using System.IO;

namespace DollarWordsConsole
{
    class Program
    {
        private const string _filePath = @"C:\testing\words\words.txt";

        static void Main(string[] args)
        {
            var wordCalculator = new WordCalculatorService();

            foreach (var word in File.ReadLines(_filePath))
            {
                var wordSum = wordCalculator.CalculateWordSum(word);
                
                if (wordSum == 100)
                {
                    Console.WriteLine(word);
                }
            }

            Console.ReadKey();
        }
    }
}
