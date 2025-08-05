using System.Security.Cryptography;
using System.Text;

namespace CalculadorHash.Utils
{
    public static class MD5CryptoHash
    {
        public static string ComputeHash(string xmlContent)
        {

            byte[] byteArray = Encoding.GetEncoding("ISO-8859-1").GetBytes(xmlContent);
            byte[] hash = MD5.HashData(byteArray);

            StringBuilder hashString = new();

            foreach (byte i in hash)
            {
                hashString.Append(i.ToString("x2"));
            }

            return hashString.ToString();
        }
    }
}
