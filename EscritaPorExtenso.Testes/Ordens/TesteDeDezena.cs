using EscritaPorExtenso.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritaPorExtenso.Testes.Ordens
{
    [TestClass]
    public class TesteDeDezena
    {
        [TestMethod]
        public void DeveGerarNumeroDeUmaDezenaSimples()
        {
            Assert.AreEqual("dez", new Dezena(1).ToString());
        }

        [TestMethod]
        public void DeveGerarUmaDezenaDaPrimeiraDezena()
        {
            Assert.AreEqual("onze", new Dezena(1, new Unidade(1)).ToString());
            Assert.AreEqual("doze", new Dezena(1, new Unidade(2)).ToString());
            Assert.AreEqual("dezesseis", new Dezena(1, new Unidade(6)).ToString());
            Assert.AreEqual("dezessete", new Dezena(1, new Unidade(7)).ToString());
            Assert.AreEqual("dezenove", new Dezena(1, new Unidade(9)).ToString());
        }

        [TestMethod]
        public void DeveGerarUmaDezenaQualquer()
        {
            Assert.AreEqual("vinte e um", new Dezena(2, new Unidade(1)).ToString());
            Assert.AreEqual("cinquenta e um", new Dezena(5, new Unidade(1)).ToString());
        }
    }
}