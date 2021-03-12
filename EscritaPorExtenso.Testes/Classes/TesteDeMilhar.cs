using EscritaPorExtenso.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritaPorExtenso.Testes.Classes
{
    [TestClass]
    public class TesteDeMilhar
    {
        [TestMethod]
        public void DeveGerarNumeroMil()
        {
            var numero = new Milhar(new Unidade(1));

            var porExtenso = numero.ToString();

            Assert.AreEqual("mil", porExtenso);
        }

        [TestMethod]
        public void DeveGerarNumeroDezMil()
        {
            var numero = new Milhar(new Dezena(1));

            var porExtenso = numero.ToString();

            Assert.AreEqual("dez mil", porExtenso);
        }

        [TestMethod]
        public void DeveGerarNumeroMilECem()
        {
            var numero = new Milhar(new Dezena(1), new PrimeiraClasse(new Centena(1)));

            var porExtenso = numero.ToString();

            Assert.AreEqual("dez mil e cem", porExtenso);
        }

        [TestMethod]
        public void DeveGerarUmMilharComClasseAnteriorCompleta()
        {
            var numero = new Milhar(new Unidade(1), new PrimeiraClasse(new Centena(9, new Dezena(8, new Unidade(4)))));

            var porExtenso = numero.ToString();

            Assert.AreEqual("mil, novecentos e oitenta e quatro", porExtenso);
        }
    }
}