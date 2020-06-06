using System;
using JetBrains.Annotations;

namespace MayoSolutions.Common.Extensions
{
    public static class StringExtensions
    {


        [Pure]
        public static bool EqualsCaseInsensitive([CanBeNull] this string a, [CanBeNull] string b)
        {
            if (a == null && b == null) return true;
            if (a == null) return false;
            return a.Equals(b, StringComparison.OrdinalIgnoreCase);
        }
    }
}
