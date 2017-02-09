using DollarWords.Services.WordCalculatorService.Interfaces;
using System;

namespace DollarWords.Services.WordCalculatorService
{
    public class WordCalculatorService : IWordCalculatorService
    {
        private const int _base = 64;

        public int CalculateWordSum(string word)
        {
            int sum = 0;

            if (string.IsNullOrWhiteSpace(word))
            {
                return sum;
            }

            foreach (var character in word.ToUpper())
            {
                if (!char.IsLetter(character))
                {
                    continue;
                }

                sum += ConvertToInt(character);
            }

            return sum;
        }

        public int ConvertToInt(char character)
        {
            var alphabeticIndex = Convert.ToInt16(character) - _base;

            return alphabeticIndex;
        }
    }
}
