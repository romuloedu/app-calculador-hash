using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorHash.Services
{
    public class CalculadorHashFactory
    {
        public static ICalculadorHash CriarInstancia(string arquivo)
        {
            arquivo = arquivo.ToLower();

            if (arquivo.EndsWith("xsip"))
            {
                return new SipService();
            }
            else if (arquivo.EndsWith("sbx"))
            {
                return new SibService();
            }
            else
            {
                return null;
            }
        }
    }
}
