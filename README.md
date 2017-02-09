# DollarWords

DollarWords is a small project that assigns a numerical value to each character in the alphabet (a = 1, b = 2, ... z = 26). 

The projects checks for words whose value is 100 when calculating the sum of each character and prints them to the screen.

Sharp, for instance has a value of (s + h + a + r + p) => (19 + 8 + 1 + 18 + 16) = 62.

## Getting Started

Clone the project:

`$ git clone https://github.com/treyhay31/DollarWords.git`

### Prerequisites

Restore the nuget packages:

`$ nuget restore ".\DollarWords.sln"`

Open solution.

`$ open ".\DollarWords.sln"`

Build & Run!

You can find the sample word file here: https://gist.github.com/treyhay31/720cbf124050438f91e0a8e94575f909

## Running the unit tests

Run the tests in Visual Studio or enter:

`.\packages\xunit.runner.console.2.1.0\tools\xunit.console.exe .\DollarWords.Tests\bin\Debug\DollarWords.Tests.dll`

Tests ensure that:

1. Numbers return a value of zero

```
[Theory]
[InlineData("0123456789")]
public void When_calculating_sum_on_numbers_IT_SHOULD_return_zero(string testData)
{
    //ARRANGE
    var sut = new WordCalculatorService();

    //ACT
    var sum = sut.CalculateWordSum(testData);

    //ASSERT
    sum.ShouldBeEquivalentTo(0);
}
```

2. Punctuation returns a value of zero

```
[Theory]
[InlineData("~!@#$%^&*()-=_+`'\"/.,?><[]{}|")]
public void When_calculating_sum_on_punctuation_IT_SHOULD_return_zero(string testData)
{
    //ARRANGE
    var sut = new WordCalculatorService();

    //ACT
    var sum = sut.CalculateWordSum(testData);

    //ASSERT
    sum.ShouldBeEquivalentTo(0);
}
```

3. Alphabetic characters return their index value

```
[Theory]
[InlineData("a", 1)]
[InlineData("b", 2)]
...
[InlineData("z", 26)]
public void WHEN_calculating_words_IT_SHOULD_return_expected_value_where_A_is_1_and_Z_is_26(string testWord, int expectedValue)
{
    //ARRANGE
    var sut = new WordCalculatorService();

    //ACT
    var sum = sut.CalculateWordSum(testWord);

    //ASSERT
    sum.ShouldBeEquivalentTo(expectedValue);
}
```