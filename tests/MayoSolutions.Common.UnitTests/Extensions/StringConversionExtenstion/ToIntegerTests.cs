using System;
using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringConversionExtenstion
{
    public class ToIntegerTests
    {


        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ThrowsWhenStringIsNullOrWhitespace(string s)
        {
            Assert.Throws<ArgumentNullException>(() => { var i = s.ToInteger(); });
        }

        [Test]
        [TestCase("-5", -5)]
        [TestCase("-1", -1)]
        [TestCase("0", 0)]
        [TestCase("6", 6)]
        [TestCase("2147483647", 2147483647)]
        [TestCase("-2147483648", -2147483648)]
        public void ConvertsAsExpected(string s, int expected)
        {
            Assert.That(s.ToInteger(), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("a")]
        [TestCase("true")]
        [TestCase("false")]
        [TestCase("4.0")]
        [TestCase("6.5")]
        public void ThrowsWhenInvalidValue(string s)
        {
            Assert.Throws<FormatException>(() => { var i = s.ToInteger(); });
        }

        [Test]
        [TestCase("2147483648")]
        [TestCase("-2147483649")]
        public void ThrowsWhenOverflowed(string s)
        {
            Assert.Throws<OverflowException>(() => { var i = s.ToInteger(); });
        }

    }
}