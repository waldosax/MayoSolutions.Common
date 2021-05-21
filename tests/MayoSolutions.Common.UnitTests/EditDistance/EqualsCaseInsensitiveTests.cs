using MayoSolutions.Common.EditDistance;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.EditDistance
{
    public class LevenshteinDistanceTests
    {
        [Test]
        [TestCase("", "", 0)]
        [TestCase("a", "", 1)]
        [TestCase("", "a", 1)]
        [TestCase("a", "A", 1)]
        [TestCase("ab", "b", 1)]
        [TestCase("ab", "ba", 2)]
        [TestCase("kitten", "sitten", 1)]
        [TestCase("sitten", "sittin", 1)]
        [TestCase("sittin", "sitting", 1)]
        [TestCase("kitten", "sitting", 3)]
        [TestCase("Saturday", "Sunday", 3)]
        [TestCase("Sunday", "Saturday", 3)]
        [TestCase("sunday", "Saturday", 4)]
        public void ShouldComputeDistance(string s, string t, int expected)
        {
            Assert.AreEqual(expected, s.LevenshteinDistance(t));
        }
    }
}
