using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EscritaPorExtenso.Testes
{
    [TestClass]
    public class TesteDeInteiro
    {
        [TestMethod]
        public void DeveEscreverUmNumeroInteiro()
        {
            Assert.AreEqual("dois mil", 2000.PorExtenso());
        }

        [DataTestMethod]
        [DataRow("cento e oito", 108)]
        [DataRow("mil e oitenta", 1080)]
        [DataRow("dez mil e noventa", 10090)]
        [DataRow("dez mil, cento e noventa e dois", 10192)]
        [DataRow("dez mil e dois", 10002)]
        public void DeveEscreverSemConjuncaoQuandoAlgumAlgarismoForZero(string numeroPorExtensoEsperado, int numero)
        {
            Assert.AreEqual(numeroPorExtensoEsperado, numero.PorExtenso());
        }

        [TestMethod]
        public void DeveEscreverUmNumeroInteiroShort()
        {
            Assert.AreEqual("um", Int16.Parse("1").PorExtenso());
        }

        [TestMethod]
        public void DeveEscreverUmNumeroInteiroLong()
        {
            Assert.AreEqual("dois mil", 2000L.PorExtenso());
        }
    }
}