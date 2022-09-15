using CalculadorHash.Utils;
using System;
using System.IO;
using System.Text;
using System.Xml;

namespace CalculadorHash.Services
{
    public class SibService : ICalculadorHash
    {
        /// Repo de apoio: https://github.com/marcostomazini/GerarHashSib
        public string CalcularHash(string xmlContent)
        {
            StringBuilder sb = new StringBuilder();

            //Esses schemas são obrigatórios, conforme documentação da ANS.
            sb.Append("http://www.ans.gov.br/padroes/sib/schemas http://www.ans.gov.br/padroes/sib/schemas/sib.xsd");

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlContent)))
            {
                do
                {
                    // Se for a tag do epílogo, ignora a leitura.
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "epilogo")) break;

                    // Se for tag de texto, adiciona ao StringBuilder.
                    if (reader.NodeType == XmlNodeType.Text) sb.Append(reader.Value);


                } while (reader.Read());
            }

            String hash = MD5CryptoHash.ComputeHash(sb.ToString());
            
            return hash.ToUpper();
        }
    }
}
