using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jogo21
{
    public class Barralho : JogoDeCartas
    {

        private List<Carta> cartas = new List<Carta>();
        public int Tamanho { get; private set; }


        public Barralho()
        {
            this.Tamanho = 0;
            CriaCartas();
        }

        private void CriaCartas()
        {
            CriaCartasDe(NAIPE.Copas);
            CriaCartasDe(NAIPE.Espadas);
            CriaCartasDe(NAIPE.Ouros);
            CriaCartasDe(NAIPE.Paus);
        }

        private void CriaCartasDe(NAIPE naipe)
        {
            for (int i = 1; i < 14; i++)
            {
                cartas.Add(new Carta(i, naipe));
                Tamanho++;
            }
        }

        public void ordenar()
        {
            throw new NotImplementedException();
        }

        public void embaralhar()
        {
            throw new NotImplementedException();
        }

        public Carta darCartas()
        {
            throw new NotImplementedException();
        }

        public string listarBaralho()
        {
            throw new NotImplementedException();
        }


    }
}