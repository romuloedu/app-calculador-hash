using CalculadorHash.Utils;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace CalculadorHash.Services
{
    public class SipService : ICalculadorHash
    {
        public string CalcularHash(string arquivo)
        {
            StringBuilder sb = new StringBuilder();

            string xmlSemHash = RemoverElementosDesnecessarios(arquivo);

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlSemHash)))
            {
                do
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "mensagemSIP")) sb.Append(reader.ReadInnerXml());

                } while (reader.Read());
            }

            string xmlHigienizado = sb.ToString().Trim().Replace("\n", "\r\n");

            return MD5CryptoHash.ComputeHash(xmlHigienizado);
        }

        private static string RemoverElementosDesnecessarios(string arquivo)
        {
            XDocument xDoc = XDocument.Load(new StreamReader(arquivo, Encoding.GetEncoding("ISO-8859-1")));

            // Remove o epílogo
            xDoc.Root?.Element("epilogo")?.Remove();

            return xDoc.ToString();
        }
    }
}
