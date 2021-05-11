using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;

namespace MayoSolutions.Common.Extensions
{
    public static class StringConversionExtensions
    {
        [Pure]
        public static bool? ToNullableBoolean([CanBeNull] this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            return bool.Parse(s);
        }

        [Pure]
        public static bool ToBoolean(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentNullException("s");
            return bool.Parse(s);
        }

        [Pure]
        public static byte? ToNullableByte([CanBeNull] this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            return byte.Parse(s);
        }

        [Pure]
        public static byte ToByte(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentNullException("s");
            return byte.Parse(s);
        }

        [Pure]
        public static int? ToNullableInteger([CanBeNull] this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            return int.Parse(s);
        }

        [Pure]
        public static int ToInteger(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentNullException("s");
            return int.Parse(s);
        }

        [Pure]
        public static long? ToNullableLong([CanBeNull] this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            return long.Parse(s);
        }

        [Pure]
        public static long ToLong(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentNullException("s");
            return long.Parse(s);
        }


        [Pure]
        public static float? ToNullableFloat([CanBeNull] this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            return float.Parse(s);
        }

        [Pure]
        public static float ToFloat(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentNullException("s");
            return float.Parse(s);
        }


        [Pure]
        public static decimal? ToNullableDecimal([CanBeNull] this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            return decimal.Parse(s);
        }

        [Pure]
        public static decimal ToDecimal(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentNullException("s");
            return decimal.Parse(s);
        }

        



        [Pure]
        public static DateTime? ToNullableDateTime([CanBeNull] this string s, params string[] formats)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            if (formats != null && formats.Any())
            {
                return DateTime.ParseExact(s, formats, null, DateTimeStyles.None);
            }

            return DateTime.Parse(s);
        }

        [Pure]
        public static DateTime ToDateTime(this string s, params string[] formats)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentNullException("s");
            if (formats != null && formats.Any())
            {
                return DateTime.ParseExact(s, formats, null, DateTimeStyles.None);
            }

            return DateTime.Parse(s);
        }




        [Pure]
        public static Guid? ToNullableGuid([CanBeNull] this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            return Guid.Parse(s);
        }

        [Pure]
        public static Guid ToGuid(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentNullException("s");
            return Guid.Parse(s);
        }

    }
}
