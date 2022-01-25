using System.Text;

namespace MayoSolutions.Common.Extensions
{
    public static class ByteArrayExtensions
    {
        public static string GetHexString(this byte[] input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in input)
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
