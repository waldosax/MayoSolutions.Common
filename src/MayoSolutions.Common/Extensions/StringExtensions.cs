using System;
using System.Globalization;
using System.Text;
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



        [Pure]
        public static string RemoveDiacritics([CanBeNull] this string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            var normalizedString = s.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        [Pure]
        public static string RemoveWhitespace([CanBeNull] this string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            char[] output = new char[s.Length];
            int l = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (!char.IsWhiteSpace(c))
                {
                    output[l] = c;
                    l++;
                }
            }

            return new string(output, 0, l);
        }

        [Pure]
        public static string RemoveNonLettersAndDigits([CanBeNull] this string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            char[] output = new char[s.Length];
            int l = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsLetterOrDigit(c))
                {
                    output[l] = c;
                    l++;
                }
            }

            return new string(output, 0, l);
        }
    }
}
