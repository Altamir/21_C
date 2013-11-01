using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo21
{
    interface JogoDeCartas
    {
        //ordenar(), embaralhar(), darCartas(), listarBaralho().
        void ordenar();
        void embaralhar();
        Carta darCartas();
        String listarBaralho();
    }
}
