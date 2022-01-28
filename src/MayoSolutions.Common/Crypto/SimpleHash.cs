using System;
using System.Security.Cryptography;
using System.Text;
using DamienG.Security.Cryptography;
using MayoSolutions.Common.Extensions;

namespace MayoSolutions.Common.Crypto
{
    public static class SimpleHash
    {
        /// <summary>
        /// Returns a simple hash from the specified bytes.
        /// </summary>
        public static byte[] GetHash(this byte[] input, SimpleHashingAlgorithm algorithm = SimpleHashingAlgorithm.SHA256)
        {
            switch (algorithm)
            {
                case SimpleHashingAlgorithm.MD5: return input.MD5Hash();
                case SimpleHashingAlgorithm.SHA1: return input.SHA1Hash();
                case SimpleHashingAlgorithm.SHA256: return input.SHA256Hash();
                case SimpleHashingAlgorithm.CRC32: return input.CRC32Hash();
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a simple hash from the specified string.
        /// </summary>
        public static byte[] GetHash(this string inputString, SimpleHashingAlgorithm algorithm = SimpleHashingAlgorithm.SHA256)
        {
            return Encoding.UTF8.GetBytes(inputString).GetHash(algorithm);
        }

        /// <summary>
        /// Returns a simple hash string from the specified bytes.
        /// </summary>
        public static string GetHashString(this byte[] input, SimpleHashingAlgorithm algorithm = SimpleHashingAlgorithm.SHA256)
        {
            return input.GetHash(algorithm).GetHexString();
        }

        /// <summary>
        /// Returns a simple hash string from the specified string.
        /// </summary>
        public static string GetHashString(this string inputString, SimpleHashingAlgorithm algorithm = SimpleHashingAlgorithm.SHA256)
        {
            return GetHashString(Encoding.UTF8.GetBytes(inputString), algorithm);
        }



        #region MD5

        /// <summary>
        /// Returns an MD5 hash.
        /// </summary>
        public static byte[] MD5Hash(this byte[] input)
        {
            using (MD5 md5 = MD5.Create())
                return md5.ComputeHash(input);
        }

        /// <summary>
        /// Returns an MD5 hash.
        /// </summary>
        public static byte[] MD5Hash(this string inputString)
        {
            return Encoding.UTF8.GetBytes(inputString).MD5Hash();
        }

        /// <summary>
        /// Returns an MD5 hash string.
        /// </summary>
        public static string MD5HashString(this byte[] input)
        {
            return input.MD5Hash().GetHexString();
        }

        /// <summary>
        /// Returns an MD5 hash string.
        /// </summary>
        public static string MD5HashString(this string inputString)
        {
            return MD5HashString(Encoding.UTF8.GetBytes(inputString));
        }

        #endregion


        #region SHA-256

        /// <summary>
        /// Returns an SHA-256 hash.
        /// </summary>
        public static byte[] SHA256Hash(this byte[] input)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(input);
        }

        /// <summary>
        /// Returns an SHA-256 hash.
        /// </summary>
        public static byte[] SHA256Hash(this string inputString)
        {
            return Encoding.UTF8.GetBytes(inputString).SHA256Hash();
        }

        /// <summary>
        /// Returns an SHA-256 hash string.
        /// </summary>
        public static string SHA256HashString(this byte[] input)
        {
            return input.SHA256Hash().GetHexString();
        }

        /// <summary>
        /// Returns an SHA-256 hash string.
        /// </summary>
        public static string SHA256HashString(this string inputString)
        {
            return SHA256HashString(Encoding.UTF8.GetBytes(inputString));
        }

        #endregion


        #region SHA-1

        /// <summary>
        /// Returns an SHA-1 hash.
        /// </summary>
        public static byte[] SHA1Hash(this byte[] input)
        {
            using (HashAlgorithm algorithm = SHA1.Create())
                return algorithm.ComputeHash(input);
        }

        /// <summary>
        /// Returns an SHA-1 hash.
        /// </summary>
        public static byte[] SHA1Hash(this string inputString)
        {
            return Encoding.UTF8.GetBytes(inputString).SHA1Hash();
        }

        /// <summary>
        /// Returns an SHA-1 hash string.
        /// </summary>
        public static string SHA1HashString(this byte[] input)
        {
            return input.SHA1Hash().GetHexString();
        }

        /// <summary>
        /// Returns an SHA-1 hash string.
        /// </summary>
        public static string SHA1HashString(this string inputString)
        {
            return SHA1HashString(Encoding.UTF8.GetBytes(inputString));
        }

        #endregion


        #region CRC32

        /// <summary>
        /// Returns a CRC32 hash.
        /// </summary>
        public static byte[] CRC32Hash(this byte[] input)
        {
            using (HashAlgorithm algorithm = new Crc32())
                return algorithm.ComputeHash(input);
        }

        /// <summary>
        /// Returns a CRC32 hash.
        /// </summary>
        public static byte[] CRC32Hash(this string inputString)
        {
            return Encoding.UTF8.GetBytes(inputString).SHA1Hash();
        }

        /// <summary>
        /// Returns a CRC32 hash.
        /// </summary>
        public static string CRC32HashString(this byte[] input)
        {
            return input.CRC32Hash().GetHexString();
        }

        /// <summary>
        /// Returns a CRC32 hash.
        /// </summary>
        public static string CRC32HashString(this string inputString)
        {
            return CRC32HashString(Encoding.UTF8.GetBytes(inputString));
        }

        #endregion

    }
}