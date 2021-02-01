using System.Globalization;
using System.Linq;

namespace Util.Texto
{
    public static class Nomes
    {
        /// <summary>
        /// Primeira letrada de cada palavra em Maiusculo. Exemplo: Helena Da Silva
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string PrimeiraLetraEmMaiusculo(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }


        /// <summary>
        /// Para padrão Brasileiro. 
        /// Exemplo: Maria Eduarda de Oliveira da Silva || Loglabs Tecnologia do Brasil Ltda.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>string</returns>
        public static string NomeDePessoa(string nome)
        {
            var result = "";
            var palavrasExcluidas = new string[] { "da", "de", "di", "do", "du", "e" };

            var palavras = nome.Split(' ');

            foreach (string palavra in palavras)
            {
                if (palavrasExcluidas.Contains(palavra))
                    result += palavra + "";
                else
                    result += PrimeiraLetraEmMaiusculo(palavra) + " ";
            }

            result = result.Trim();

            return result;
        }
    }
}
