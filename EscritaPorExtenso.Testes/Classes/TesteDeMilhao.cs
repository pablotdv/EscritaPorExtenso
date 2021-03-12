using EscritaPorExtenso.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritaPorExtenso.Testes.Classes
{
    [TestClass]
    public class TesteDeMilhao
    {
        [DataTestMethod]
        [DataRow("um milhão", 1)]
        [DataRow("cinco milhões", 5)]
        [DataRow("nove milhões", 9)]
        public void DeveEscreverPorExtensoUnidadeDeMilhao(string numeroPorExtenso, int unidade)
        {
            Assert.AreEqual(numeroPorExtenso, new Milhao(new Unidade(unidade)).ToString());
        }

        [TestMethod]
        public void ObjetosDiferentesDevemSerDiferentes()
        {
            Assert.IsFalse(new Milhao(new Unidade(1)).Equals(1));
        }

        [TestMethod]
        public void DeveSerDiferenteSeObjetoForNulo()
        {
            Assert.IsFalse(new Milhao(new Unidade(1)).Equals(null));
        }

        [TestMethod]
        public void DeveSerIgual()
        {
            var milhao = new Milhao(new Unidade(1));
            Assert.IsTrue(new Milhao(new Unidade(1)).Equals(milhao));
        }

        [TestMethod]
        public void HashcodeDaClasseDeveSerONumeroPorExtenso()
        {
            var umMilhao = new Milhao(new Unidade(1));

            Assert.AreEqual(umMilhao.GetHashCode(), umMilhao.ToString().GetHashCode());
        }

        [DataTestMethod]
        [DataRow("dez milhões", 1)]
        [DataRow("vinte milhões", 2)]
        [DataRow("noventa milhões", 9)]
        public void DeveEscreverPorExtensoDezenaDeMilhao(string numeroPorExtenso, int dezena)
        {
            Assert.AreEqual(numeroPorExtenso, new Milhao(new Dezena(dezena)).ToString());
        }

        [TestMethod]
        public void DeveGerarNumeroUmMilhaoECemMil()
        {
            Assert.AreEqual("um milhão e cem mil", new Milhao(new Unidade(1), new Milhar(new Centena(1))).ToString());
        }

        [TestMethod]
        public void DeveGerarNumeroUmMilhaoECemMilEUm()
        {
            Assert.AreEqual("um milhão e cem mil e um", new Milhao(new Unidade(1), new Milhar(new Centena(1), new PrimeiraClasse(new Unidade(1)))).ToString());
        }

        [TestMethod]
        public void DeveGerarNumero1111e3()
        {
            Assert.AreEqual("um milhão, cento e onze mil", new Milhao(new Unidade(1), new Milhar(new Centena(1, new Dezena(1, new Unidade(1))))).ToString());
        }
    }
}