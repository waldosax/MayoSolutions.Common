using System;
using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringConversionExtenstion
{
    public class ToLongTests
    {


        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ThrowsWhenStringIsNullOrWhitespace(string s)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var i = s.ToLong();
            });
        }

        [Test]
        [TestCase("-5", -5)]
        [TestCase("-1", -1)]
        [TestCase("0", 0)]
        [TestCase("6", 6)]
        [TestCase("2147483647", 2147483647)]
        [TestCase("-2147483648", -2147483648)]
        [TestCase("9223372036854775807", 9223372036854775807)]
        [TestCase("-9223372036854775808", -9223372036854775808)]
        public void ConvertsAsExpected(string s, long expected)
        {
            Assert.That(s.ToLong(), Is.EqualTo(expected));
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
                var i = s.ToLong();
            });
        }

        [Test]
        [TestCase("9223372036854775808")]
        [TestCase("-9223372036854775809")]
        public void ThrowsWhenOverflowed(string s)
        {
            Assert.Throws<OverflowException>(() =>
            {
                var i = s.ToLong();
            });
        }

    }
}