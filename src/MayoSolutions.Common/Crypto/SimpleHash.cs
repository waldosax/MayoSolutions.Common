using System.Security.Cryptography;
using System.Text;

namespace MayoSolutions.Common.Crypto
{
    public static class SimpleHash
    {
        public static byte[] GetHash(this byte[] input)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(input);
        }

        public static byte[] GetHash(this string inputString)
        {
            return GetHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(this byte[] input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(input))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static string GetHashString(this string inputString)
        {
            return GetHashString(Encoding.UTF8.GetBytes(inputString));
        }
    }
}