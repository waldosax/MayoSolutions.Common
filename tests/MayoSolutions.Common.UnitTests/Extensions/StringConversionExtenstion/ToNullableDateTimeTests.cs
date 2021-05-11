using System;
using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringConversionExtenstion
{
    public class ToNullableDateTimeTests
    {

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ReturnsNullWhenStringIsNullOrWhitespace(string s)
        {
            Assert.That(s.ToNullableDateTime(), Is.Null);
        }

        private static object[][] ConvertsAsExpectedTestCases()
        {
            return new[]
            {
                new object[] {"5/11/2021", new DateTime(2021, 5, 11)},
                new object[] {"5-11-2021", new DateTime(2021, 5, 11)},
                new object[] {"5/11/21", new DateTime(2021, 5, 11)},
                new object[] {"5-11-21", new DateTime(2021, 5, 11)},
                new object[] { "Monday, June 15, 2009 1:45 PM", new DateTime(2009, 6, 15, 13, 45, 0)},
            };
        }

        [Test]
        [TestCaseSource(nameof(ConvertsAsExpectedTestCases))]
        public void ConvertsAsExpected(string s, DateTime? expected)
        {
            Assert.That(s.ToNullableDateTime(), Is.EqualTo(expected));
        }
        

        [Test]
        [TestCase("a")]
        [TestCase("2021-05-11")]
        public void ThrowsWhenInvalidValue(string s)
        {
            Assert.Throws<FormatException>(() =>
            {
                var b = s.ToNullableBoolean();
            });
        }

        private static object[][] ConvertsAsExpectedWithFormatsTestCases()
        {
            return new[]
            {
                new object[] {"5/11/2021", new[] { "M/d/yyyy" }, new DateTime(2021, 5, 11)},
                new object[] {"5-11-2021", new[] { "M-d-yyyy" }, new DateTime(2021, 5, 11)},
                new object[] {"5/11/21", new[] { "M/d/yy" }, new DateTime(2021, 5, 11)},
                new object[] {"5-11-21", new[] { "M-d-yy" }, new DateTime(2021, 5, 11)},
                new object[] { "2021-05-11", new[] { "yyyy-MM-dd" }, new DateTime(2021, 5, 11)},
            };
        }

        [Test]
        [TestCaseSource(nameof(ConvertsAsExpectedWithFormatsTestCases))]
        public void ConvertsAsExpectedWithFormats(string s, string[] formats, DateTime? expected)
        {
            Assert.That(s.ToNullableDateTime(formats), Is.EqualTo(expected));
        }

    }
}
