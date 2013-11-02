using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Jogo21
{
    public class CartasNomes
    {

        public static String NomeCartaPor(int valor)
        {
            StringBuilder retorno = new StringBuilder();

            switch (valor)
            {
                case 1:
                    retorno.Append("Ás");
                    break;
                case 11:
                    retorno.Append("Velete");
                    break;
                case 12:
                    retorno.Append("Dama");
                    break;
                case 13:
                    retorno.Append("Rei");
                    break;
                default:
                    retorno.Append(valor.ToString());
                    break;
            }
            return retorno.ToString();
        }

    }
}