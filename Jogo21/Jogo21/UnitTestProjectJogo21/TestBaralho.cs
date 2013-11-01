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
        public void RetornaQtCartasDoBaralho()
        {
            var esperado = 52;

            Assert.AreEqual(esperado, baralho.Tamanho);
        }
    }
}
