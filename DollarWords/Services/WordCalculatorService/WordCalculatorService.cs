using DollarWords.Services.WordCalculatorService.Interfaces;
using System;

namespace DollarWords.Services.WordCalculatorService
{
    /// <summary>
    /// A class that converts string word values into numeric values
    /// by summing their respective alphabetic indexes.
    /// a = 1
    /// b = 2
    /// ...
    /// z = 26
    /// </summary>
    public class WordCalculatorService : IWordCalculatorService
    {
        private const int _base = 64;

        /// <summary>
        /// Method that does the actual calculation on the <see cref="string">word</see>.
        /// </summary>
        /// <param name="word"><see cref="string">word</see> to be calculated</param>
        /// <returns><see cref="int">sum</see> of the word's letters</returns>
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

        /// <summary>
        /// Method converts <see cref="char">char values</see> to <see cref="int">int values</see>
        /// </summary>
        /// <param name="character"><see cref="char">character</see> to be converted</param>
        /// <returns>character's <see cref="int">index</see> in the alphabet</returns>
        public int ConvertToInt(char character)
        {
            var alphabeticIndex = Convert.ToInt16(character) - _base;

            return alphabeticIndex;
        }
    }
}
