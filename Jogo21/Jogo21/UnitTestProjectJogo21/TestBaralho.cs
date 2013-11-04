using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jogo21;


namespace UnitTestProjectJogo21
{
    [TestClass]
    public class TestBaralho
    {

        private Barralho baralho;

        [TestInitialize]
        public void SetUp()
        {
            baralho = new Barralho();
        }

        [TestMethod]
        public void RetornaQtCartasDoBaralho_Igual_52()
        {
            var esperado = 52;
            Assert.AreEqual(esperado, baralho.Tamanho);
        }

        [TestMethod]
        public void Test_ListarCartasEmbaralhadas()
        {
            baralho.embaralhar();
            Assert.AreNotEqual(StringEsperadas.BaralhoOrdenado(), baralho.listarBaralho());
        }

        [TestMethod]
        public void Test_ordenarCartas()
        {
            baralho.ordenar();
            Assert.AreEqual(StringEsperadas.BaralhoOrdenado(), baralho.listarBaralho());
        }

        [TestMethod]
        public void Test_ListarCartasOrdenadas()
        {
            Assert.AreEqual(StringEsperadas.BaralhoOrdenado(), baralho.listarBaralho());
        }

        [TestMethod]
        public void Test_DarCartaBaralhoOrdenado()
        {
            Assert.AreEqual("Ás de Copas", baralho.darCartas().ToString());
            Assert.AreEqual("2 de Copas",baralho.darCartas().ToString());
        }
    }
}
