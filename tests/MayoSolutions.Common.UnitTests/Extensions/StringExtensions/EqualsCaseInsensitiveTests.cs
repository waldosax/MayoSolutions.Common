using System;
using System.Collections.Generic;
using System.Text;
using MayoSolutions.Common.Extensions;
using NUnit.Framework;

namespace MayoSolutions.Common.UnitTests.Extensions.StringExtensions
{
    public class EqualsCaseInsensitiveTests
    {
        [Test]
        [TestCase(null, null, true)]
        [TestCase(null, "", false)]
        [TestCase(null, "b", false)]
        [TestCase("", null, false)]
        [TestCase("a", null, false)]
        [TestCase("", "", true)]
        [TestCase("a", "a", true)]
        [TestCase("a", "A", true)]
        [TestCase("a", "b", false)]
        [TestCase("b", "b", true)]
        [TestCase("B", "b", true)]
        [TestCase("a", "B", false)]
        [TestCase("A", "b", false)]
        public void ShouldMakeCaseInsensitiveComparisons(string a, string b, bool expected)
        {
            Assert.AreEqual(expected, a.EqualsCaseInsensitive(b));
        }
    }
}
