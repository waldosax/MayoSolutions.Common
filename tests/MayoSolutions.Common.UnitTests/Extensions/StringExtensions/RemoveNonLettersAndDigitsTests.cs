using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringExtensions
{
    public class RemoveNonLettersAndDigitsTests
    {
        [Test]
        [TestCase(null, null)]
        [TestCase("", "")]
        [TestCase(" ", "")]
        [TestCase("American Dream", "AmericanDream")]
        [TestCase("American-Dream", "AmericanDream")]
        [TestCase("\tAmerican-Dream", "AmericanDream")]
        [TestCase("\tAmerican-Dream   ", "AmericanDream")]
        [TestCase("\bAmerican-Dream", "AmericanDream")]
        [TestCase("American_Dream", "AmericanDream")]
        [TestCase("American Dream!!!", "AmericanDream")]
        public void ShouldRemoveAllNonLettersAndDigits(string s, string expected)
        {
            Assert.AreEqual(expected, s.RemoveNonLettersAndDigits());
        }
    }
}