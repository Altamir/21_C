using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jogo21;

namespace UnitTestProjectJogo21
{
    [TestClass]
    public class TestCarta
    {

        private  Carta carta;

       
        [TestInitialize]
        public void SetUp()
        {
            carta = new Carta(1, NAIPE.Copas);
        }


        [TestMethod]
        public void Testa_Retorno_Naipe_Copas()
        {
            var esperado = NAIPE.Copas;

            Assert.AreEqual(esperado, carta.Naipe);
        }

        [TestMethod]
        public void Testa_retornaValor_1_daCarta()
        {
            var esperada = 1;

            Assert.AreEqual(esperada, carta.Valor);
        }

        [TestMethod]
        public void Testa_retorna_As_de_Copas_como_String()
        {
            var esperada = "Ás de Copas";

            Assert.AreEqual(esperada, carta.ToString());
        }
    }
}
