﻿using System;
using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringConversionExtenstion
{
    public class ToDecimalTests
    {

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ThrowsWhenStringIsNullOrWhitespace(string s)
        {
            Assert.Throws<ArgumentNullException>(() => { var d = s.ToDecimal(); });
        }

        [Test]
        [TestCase("-5", -5)]
        [TestCase("-1", -1)]
        [TestCase("0", 0)]
        [TestCase("6", 6)]
        [TestCase("3.6", 3.6)]
        [TestCase("-3.6", -3.6)]
        public void ConvertsAsExpected(string s, decimal expected)
        {
            Assert.That(s.ToDecimal(), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("a")]
        [TestCase("true")]
        [TestCase("false")]
        public void ThrowsWhenInvalidValue(string s)
        {
            Assert.Throws<FormatException>(() => { var d = s.ToDecimal(); });
        }

    }
}