using System.Security.Cryptography;
using System.Text;

namespace CalculadorHash.Utils
{
    public static class MD5CryptoHash
    {
        public static string ComputeHash(string xmlContent)
        {
            using var md5 = MD5.Create();

            byte[] byteArray = Encoding.GetEncoding("ISO-8859-1").GetBytes(xmlContent);
            byte[] hash = md5.ComputeHash(byteArray);

            StringBuilder hashString = new StringBuilder();

            foreach (byte i in hash)
            {
                hashString.Append(i.ToString("x2"));
            }

            return hashString.ToString();
        }
    }
}
