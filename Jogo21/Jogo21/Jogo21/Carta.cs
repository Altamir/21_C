using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;


namespace Jogo21
{
    public class Carta : IComparable<Carta>
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
            return GeraStringValor() + " de " + GeraStringNaipe();
        }

        private string GeraStringNaipe()
        {
            return CartasNomes.NomeCartaPor(Naipe);
        }

        private string GeraStringValor()
        {
            return CartasNomes.NomeCartaPor(Valor);
        }


        public int CompareTo(Carta outraCarta)
        {
            if(this.Valor < outraCarta.Valor)
            {
                return -1;
            }
            if (this.Valor > outraCarta.Valor)
            {
                return 1;
            }
            return 0;
        }
    }
}