using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo21;

namespace UnitTestProjectJogo21
{
    class StringEsperadas
    {
        public static String BaralhoOrdenado()
        {
            StringBuilder retorno = new StringBuilder();

            CriaStringDo(NAIPE.Copas, retorno);
            CriaStringDo(NAIPE.Espadas, retorno);
            CriaStringDo(NAIPE.Ouros, retorno);
            CriaStringDo(NAIPE.Paus, retorno);

            return retorno.ToString();
        }

        private static void CriaStringDo(NAIPE naipe, StringBuilder retorno)
        {
            for (int valor = 1; valor < 14; valor++)
            {
                retorno.Append(CartasNomes.NomeCartaPor(valor) +
                    " de " + CartasNomes.NomeCartaPor(naipe) + "\n");
            }
        }
    }
}
