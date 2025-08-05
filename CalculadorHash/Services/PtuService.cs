using CalculadorHash.Utils;
using System.Text;

namespace CalculadorHash.Services
{
    public class PtuService : ICalculadorHash
    {
        public string CalcularHash(string arquivo)
        {
            string conteudo = File.ReadAllText(arquivo, Encoding.GetEncoding("ISO-8859-1"));

            // Remove quebras de linha (\r e \n) seguindo a lógica do Python
            string conteudoSemQuebras = conteudo.Replace("\r", "").Replace("\n", "");

            // Remove os últimos 43 caracteres (conforme código Python: [:-43])
            string conteudoTratado = conteudoSemQuebras.Length > 43
                ? conteudoSemQuebras[..^43]
                : "";

            return MD5CryptoHash.ComputeHash(conteudoTratado);
        }
    }
}
