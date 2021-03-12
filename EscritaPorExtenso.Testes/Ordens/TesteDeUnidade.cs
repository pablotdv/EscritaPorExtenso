using EscritaPorExtenso.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritaPorExtenso.Testes.Ordens
{
    [TestClass]
    public class TesteDeUnidade
    {
        [TestMethod]
        public void DeveGerarNumeroPorExtensoDeUnidade()
        {
            Assert.AreEqual("um", new Unidade(1).ToString());
        }
    }
}
