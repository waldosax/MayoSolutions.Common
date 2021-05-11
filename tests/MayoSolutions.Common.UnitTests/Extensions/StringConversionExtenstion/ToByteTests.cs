using System;
using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringConversionExtenstion
{
    public class ToByteTests
    {

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ThrowsWhenStringIsNullOrWhitespace(string s)
        {
            Assert.Throws<ArgumentNullException>(() => { var b = s.ToByte(); });
        }

        [Test]
        [TestCase("0", 0)]
        [TestCase("6", 6)]
        public void ConvertsAsExpected(string s, byte expected)
        {
            Assert.That(s.ToByte(), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("a")]
        [TestCase("true")]
        [TestCase("false")]
        [TestCase("4.0")]
        [TestCase("6.5")]
        public void ThrowsWhenInvalidValue(string s)
        {
            Assert.Throws<FormatException>(() =>
            {
                var b = s.ToByte();
            });
        }

        [Test]
        [TestCase("256")]
        [TestCase("-1")]
        public void ThrowsWhenOverflowed(string s)
        {
            Assert.Throws<OverflowException>(() =>
            {
                var b = s.ToByte();
            });
        }
    }
}