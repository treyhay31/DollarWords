using DollarWords.Services.WordCalculatorService;
using FluentAssertions;
using Xunit;

namespace DollarWords.Tests
{
    public class WordCalculatorServiceTests
    {
        [Theory]
        [InlineData("0123456789")]
        [InlineData("(999)123-1234")]
        [InlineData("999-123-1234")]
        [InlineData("$10.00")]
        [InlineData("3.14")]
        public void When_calculating_sum_on_numbers_IT_should_return_zero(string testData)
        {
            //ARRANGE
            var sut = new WordCalculatorService();

            //ACT
            var sum = sut.CalculateWordSum(testData);

            //ASSERT
            sum.ShouldBeEquivalentTo(0);
        }

        [Theory]
        [InlineData("~!@#$%^&*()-=_+`'\"/.,?><[]{}|")]
        [InlineData("****")]
        [InlineData("'''")]
        [InlineData("\"\"\"")]
        [InlineData("-,'")]
        public void When_calculating_sum_on_punctuation_IT_should_return_zero(string testData)
        {
            //ARRANGE
            var sut = new WordCalculatorService();

            //ACT
            var sum = sut.CalculateWordSum(testData);

            //ASSERT
            sum.ShouldBeEquivalentTo(0);
        }

        [Theory]
        [InlineData("a", 1)]
        [InlineData("b", 2)]
        [InlineData("c", 3)]
        [InlineData("d", 4)]
        [InlineData("e", 5)]
        [InlineData("f", 6)]
        [InlineData("g", 7)]
        [InlineData("h", 8)]
        [InlineData("i", 9)]
        [InlineData("j", 10)]
        [InlineData("k", 11)]
        [InlineData("l", 12)]
        [InlineData("m", 13)]
        [InlineData("n", 14)]
        [InlineData("o", 15)]
        [InlineData("p", 16)]
        [InlineData("q", 17)]
        [InlineData("r", 18)]
        [InlineData("s", 19)]
        [InlineData("t", 20)]
        [InlineData("u", 21)]
        [InlineData("v", 22)]
        [InlineData("w", 23)]
        [InlineData("x", 24)]
        [InlineData("y", 25)]
        [InlineData("z", 26)]
        [InlineData("yyyy", 100)]
        [InlineData("yyyz", 101)]
        [InlineData("yy _!@543#$ yy", 100)]
        [InlineData("_!@543#$,.?>< yyyy", 100)]
        [InlineData("yyyy _+=-1423!@#$ ", 100)]
        [InlineData("yyyz _+=-1423!@#$", 101)]
        public void WHEN_calculating_words_IT_SHOULD_return_expected_value_where_A_is_1_and_Z_is_26(string testWord, int expectedValue)
        {
            //ARRANGE
            var sut = new WordCalculatorService();

            //ACT
            var sum = sut.CalculateWordSum(testWord);

            //ASSERT
            sum.ShouldBeEquivalentTo(expectedValue);
        }
    }
}
