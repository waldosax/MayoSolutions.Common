using System;
using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringConversionExtenstion
{

    public class ToNullableBooleanTests
    {

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ReturnsNullWhenStringIsNullOrWhitespace(string s)
        {
            Assert.That(s.ToNullableBoolean(), Is.Null);
        }

        [Test]
        [TestCase("true", true)]
        [TestCase("false", false)]
        [TestCase("True", true)]
        [TestCase("False", false)]
        public void ConvertsAsExpected(string s, bool expected)
        {
            Assert.That(s.ToNullableBoolean(), Is.EqualTo(expected));
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
            Assert.Throws<FormatException>(() =>
            {
                var b = s.ToNullableBoolean();
            });
        }
    }
}
