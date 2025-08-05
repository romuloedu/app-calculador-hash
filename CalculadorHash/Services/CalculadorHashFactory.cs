using System;

namespace CalculadorHash.Services
{
    public static class CalculadorHashFactory
    {
        public static ICalculadorHash? CriarInstancia(string arquivo)
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
