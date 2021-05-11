using System;
using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringConversionExtenstion
{
    public class ToBooleanTests
    {

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ThrowsWhenStringIsNullOrWhitespace(string s)
        {
            Assert.Throws<ArgumentNullException>(() => { var b = s.ToBoolean(); });
        }

        [Test]
        [TestCase("true", true)]
        [TestCase("false", false)]
        [TestCase("True", true)]
        [TestCase("False", false)]
        public void ConvertsAsExpected(string s, bool expected)
        {
            Assert.That(s.ToBoolean(), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("a")]
        [TestCase("Yes")]
        [TestCase("No")]
        [TestCase("yes")]
        [TestCase("no")]
        [TestCase("1")]
        [TestCase("0")]
        public void ThrowsWhenInvalidValue(string s)
        {
            Assert.Throws<FormatException>(() => { var b = s.ToBoolean(); });
        }

    }
}