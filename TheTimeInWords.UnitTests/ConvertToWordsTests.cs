using NUnit.Framework;

namespace TheTimeInWordsHackerRank.UnitTests
{
    [TestFixture]
    internal class ConvertToWordsTests
    {
        [TestCase(3, 00, ExpectedResult = "three o' clock")]
        [TestCase(5, 00, ExpectedResult = "five o' clock")]
        [TestCase(5, 01, ExpectedResult = "one minute past five")]
        [TestCase(5, 10, ExpectedResult = "ten minutes past five")]
        [TestCase(5, 15, ExpectedResult = "quarter past five")]
        [TestCase(5, 28, ExpectedResult = "twenty eight minutes past five")]
        [TestCase(5, 30, ExpectedResult = "half past five")]
        [TestCase(5, 32, ExpectedResult = "twenty eight minutes to six")]
        [TestCase(5, 40, ExpectedResult = "twenty minutes to six")]
        [TestCase(5, 45, ExpectedResult = "quarter to six")]
        [TestCase(5, 47, ExpectedResult = "thirteen minutes to six")]
        [TestCase(7, 15, ExpectedResult = "quarter past seven")]
        public string ToWords_SampleInput_GetConverted(int h, int m) => 
            ConvertToWords.ToWords(h, m);
    }
}
