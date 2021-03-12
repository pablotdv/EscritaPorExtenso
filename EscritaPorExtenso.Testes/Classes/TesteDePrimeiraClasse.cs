using EscritaPorExtenso.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritaPorExtenso.Testes
{
    [TestClass]
    public class TesteDePrimeiraClasse
    {
        [TestMethod]
        public void PrimeiraClasseNaoTemSufixo()
        {
            Assert.AreEqual("", new PrimeiraClasse(new Unidade(1)).Sufixo);
        }
    }
}

