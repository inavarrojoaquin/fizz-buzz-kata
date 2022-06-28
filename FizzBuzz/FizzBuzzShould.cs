using NUnit.Framework;

namespace FizzBuzz
{
    public class FizzBuzzShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("4", 4)]
        public void ConvertInputNumberToString(string expectedString, int input)
        {
            Assert.AreEqual(expectedString, new FizzBuzzGenerator().Convert(input));
        }

        [TestCase("Fizz", 3)]
        [TestCase("Fizz", 6)]
        [TestCase("Fizz", 9)]
        public void ConvertMultipleOfThreeToFizz(string expectedString, int input)
        {
            Assert.AreEqual(expectedString, new FizzBuzzGenerator().Convert(input));
        }

        [TestCase("Buzz", 5)]
        [TestCase("Buzz", 10)]
        [TestCase("Buzz", 20)]
        public void ConvertMultipleOfFiveToBuzz(string expectedString, int input)
        {
            Assert.AreEqual(expectedString, new FizzBuzzGenerator().Convert(input));
        }

        [TestCase("FizzBuzz", 15)]
        [TestCase("FizzBuzz", 30)]
        [TestCase("FizzBuzz", 45)]
        public void ConvertMultipleOfThreeAndFiveToFizzBuzz(string expectedString, int input)
        {
            Assert.AreEqual(expectedString, new FizzBuzzGenerator().Convert(input));
        }

    }
}