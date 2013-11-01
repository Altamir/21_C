using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;


namespace Jogo21
{
    public class Carta
    {
        private int valor;
        private NAIPE naipe;


        public Carta(int valor, NAIPE naipe)
        {
            this.valor = valor;
            this.naipe = naipe;
        }

        public int Valor
        {
            get { return valor; }
        }

        public NAIPE Naipe
        {
            get { return naipe; }
        }

        public override string ToString()
        {
            return GeraStringValor() + " de " + naipe.ToString();
        }

        private string GeraStringValor()
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