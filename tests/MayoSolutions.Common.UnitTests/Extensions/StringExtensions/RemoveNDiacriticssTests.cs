using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringExtensions
{
    public class RemoveNDiacriticssTests
    {
        [Test]
        [TestCase(null, null)]
        [TestCase("", "")]
        [TestCase("American Dream", "American Dream")]
        [TestCase("Āmerican Dream", "American Dream")]
        [TestCase("Āmerićan Dream", "American Dream")]
        public void ShouldRemoveAllDiacritics(string s, string expected)
        {
            Assert.AreEqual(expected, s.RemoveDiacritics());
        }
    }
}