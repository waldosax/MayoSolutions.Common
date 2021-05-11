using System;
using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringConversionExtenstion
{
    public class ToFloatTests
    {
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ThrowsWhenStringIsNullOrWhitespace(string s)
        {
            Assert.Throws<ArgumentNullException>(() => { var f = s.ToFloat(); });
        }

        [Test]
        [TestCase("-5", -5)]
        [TestCase("-1", -1)]
        [TestCase("0", 0)]
        [TestCase("6", 6)]
        [TestCase("3.40282347E+38", 3.40282347E+38f)]
        [TestCase("-3.40282347E+38", -3.40282347E+38f)]
        public void ConvertsAsExpected(string s, float expected)
        {
            Assert.That(s.ToFloat(), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("a")]
        [TestCase("true")]
        [TestCase("false")]
        public void ThrowsWhenInvalidValue(string s)
        {
            Assert.Throws<FormatException>(() => { var f = s.ToFloat(); });
        }
        

    }
}