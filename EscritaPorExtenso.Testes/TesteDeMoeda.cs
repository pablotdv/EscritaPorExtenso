using EscritaPorExtenso.Conversor;
using EscritaPorExtenso.Moeda;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EscritaPorExtenso.Testes
{
    [TestClass]
    public class TesteDeMoeda
    {
        [TestMethod]
        public void DeveEscreverNumeroSingular()
        {
            Assert.AreEqual("um real", 1.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveEscreverNumeroPlural()
        {
            Assert.AreEqual("dois reais", 2.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveEscreverNumeroComCentavoSingular()
        {
            Assert.AreEqual("um real e um centavo", 1.01m.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveEscreverSemConjuncaoQuandoAlgumAlgarismoForZero()
        {
            Assert.AreEqual("cento e oito reais", 108.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveEscreverNumeroComCentavoPlural()
        {
            Assert.AreEqual("duzentos reais e cinquenta centavos", 200.50.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveEscreverNumeroSomenteComCentavos()
        {
            Assert.AreEqual("noventa e nove centavos", 0.99.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveEscreverNumeroSomenteComCentavosDecimal()
        {
            Assert.AreEqual("noventa e nove centavos", 0.99m.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveEscreverNumeroSomenteComCentavosFloat()
        {
            Assert.AreEqual("noventa e nove centavos", 0.99f.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveEscreverNumeroSomenteComCentavosInt()
        {
            Assert.AreEqual("nove reais", 9.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveEscreverNumeroSomenteComCentavosLong()
        {
            Assert.AreEqual("um real", 1L.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveEscreverNumero1000()
        {
            Assert.AreEqual("mil reais", 1000.PorExtensoDeReal());
        }

        [TestMethod]
        public void DeveFuncionarParaNumerosComAcentos()
        {
            Assert.AreEqual("três reais", 3.PorExtensoDeReal());
        }

        [TestMethod]
        public void ZeroDeveSerSingular()
        {
            // + info em http://vestibular.uol.com.br/pegadinhas/ult1796u122.jhtm
            Assert.AreEqual("zero real", 0.PorExtensoDeReal());
        }

        [TestMethod]
        public void NaoDeveConverterNumeroMaiorQueOSuportado()
        {
            var numeroMaiorQueOMaximo = Convert.ToInt64(new string('9', ConversorDeNumeroParaClasses.NumeroDeClasses * 3 + 1));

            var excecao = Assert.ThrowsException<Exception>(() => numeroMaiorQueOMaximo.PorExtensoDeReal());
            Assert.AreEqual(string.Format("O valor {0} é maior que o suportado pela biblioteca", numeroMaiorQueOMaximo), excecao.Message);
        }

        [TestMethod]
        public void NaoDeveConverterNumeroComMaisDeDuasCasasDecimais()
        {
            var valor = 0.999;

            var excecao = Assert.ThrowsException<Exception>(() => valor.PorExtensoDeReal());

            Assert.AreEqual(string.Format("O valor {0} tem mais de duas casas decimais", valor), excecao.Message);
        }
    }
}

