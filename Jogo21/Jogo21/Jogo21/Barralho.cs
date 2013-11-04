using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace Jogo21
{
    public class Barralho : JogoDeCartas
    {

        private List<Carta> cartas = new List<Carta>();
        private int topo;


        public Barralho()
        {
            topo = -1;
            CriaCartas();
        }

        public int Tamanho
        {
            get { return cartas.Count;}
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

            }
        }

        public void ordenar()
        {
            cartas =  OrdenadorDeBaralho(cartas);
        }

        public void embaralhar()
        {
            cartas.Sort();
        }

        public Carta darCartas()
        {
            topo++;
            return cartas[topo];
        }

        public string listarBaralho()
        {
            StringBuilder retorno = new StringBuilder();
            foreach (Carta carta in cartas)
            {
                retorno.Append(carta.ToString() + "\n");
            }
            return retorno.ToString();
        }


        public static List<Carta> OrdenadorDeBaralho(List<Carta> cartasDoBaralho)
        {
            List<Carta> baralhoDeCopas = new List<Carta>();
            List<Carta> baralhoDeEspadas = new List<Carta>();
            List<Carta> baralhoDeOuros = new List<Carta>();
            List<Carta> baralhoDePaus = new List<Carta>();

            foreach (Carta carta in cartasDoBaralho)
            {
                switch (carta.Naipe)
                {
                    case NAIPE.Copas:
                        baralhoDeCopas.Add(carta);
                        break;
                    case NAIPE.Ouros:
                        baralhoDeOuros.Add(carta);
                        break;
                    case NAIPE.Espadas:
                        baralhoDeEspadas.Add(carta);
                        break;
                    case NAIPE.Paus:
                        baralhoDePaus.Add(carta);
                        break;
                }
            }

            baralhoDeCopas.Sort();
            baralhoDeOuros.Sort();
            baralhoDeOuros.Sort();
            baralhoDeOuros.Sort();

            List<Carta> ordenadas = new List<Carta>();
            ordenadas.AddRange(baralhoDeCopas);
            ordenadas.AddRange(baralhoDeEspadas);
            ordenadas.AddRange(baralhoDeOuros);
            ordenadas.AddRange(baralhoDePaus);
            return ordenadas;

        }
    }
}