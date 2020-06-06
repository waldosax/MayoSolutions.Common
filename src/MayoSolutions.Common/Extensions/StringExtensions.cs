using System;
using System.Diagnostics.Contracts;

namespace MayoSolutions.Common.Extensions
{
    public static class StringExtensions
    {


        [Pure]
        public static bool EqualsCaseInsensitive(this string a, string b)
        {
            if (a == null && b == null) return true;
            if (a == null) return false;
            return a.Equals(b, StringComparison.OrdinalIgnoreCase);
        }
    }
}
