using System;
using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringConversionExtenstion
{
    public class ToGuidTests
    {

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ThrowsWhenStringIsNullOrWhitespace(string s)
        {
            Assert.Throws<ArgumentNullException>(() => { var g = s.ToGuid(); });
        }

        private static object[][] ConvertsAsExpectedTestCases()
        {
            return new[]
            {
                new object[] {"12345678-abcd-EFAB-0123-123456789012", Guid.Parse("{12345678-abcd-EFAB-0123-123456789012}") },
                new object[] {"{12345678-abcd-EFAB-0123-123456789012}", Guid.Parse("12345678-abcd-EFAB-0123-123456789012") },
                new object[] {"(12345678-abcd-EFAB-0123-123456789012)", Guid.Parse("12345678-abcd-EFAB-0123-123456789012") },
                new object[] {"12345678abcdEFAB0123123456789012", Guid.Parse("12345678-abcd-EFAB-0123-123456789012") },
            };
        }

        [Test]
        [TestCaseSource(nameof(ConvertsAsExpectedTestCases))]
        public void ConvertsAsExpected(string s, Guid? expected)
        {
            Assert.That(s.ToGuid(), Is.EqualTo(expected));
        }
        

        [Test]
        [TestCase("a")]
        [TestCase("2021-05-11")]
        [TestCase("{12345678-abcd-EFAB-0123-1234567890123}")]
        [TestCase("{12345678-abcd-EFAB-0123-123456789012")]
        public void ThrowsWhenInvalidValue(string s)
        {
            Assert.Throws<FormatException>(() =>
            {
                var g = s.ToGuid();
            });
        }
        

    }
}