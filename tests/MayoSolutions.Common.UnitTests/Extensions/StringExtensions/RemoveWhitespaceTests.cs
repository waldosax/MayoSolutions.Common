using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringExtensions
{
    public class RemoveWhitespaceTests
    {
        [Test]
        [TestCase(null, null)]
        [TestCase("", "")]
        [TestCase(" ", "")]
        [TestCase("\t", "")]
        [TestCase("a", "a")]
        [TestCase("American Dream", "AmericanDream")]
        [TestCase(" American Dream", "AmericanDream")]
        [TestCase(" American Dream ", "AmericanDream")]
        [TestCase("\t American Dream \t", "AmericanDream")]
        [TestCase(" \tAmerican Dream\t ", "AmericanDream")]
        [TestCase("  \tAmerican Dream\t  ", "AmericanDream")]
        public void ShouldRemoveAllWhitespace(string s, string expected)
        {
            Assert.AreEqual(expected, s.RemoveWhitespace());
        }
    }
}