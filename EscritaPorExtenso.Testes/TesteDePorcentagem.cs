using EscritaPorExtenso.Conversor;
using EscritaPorExtenso.Porcentagem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EscritaPorExtenso.Testes
{
    /*
     * http://www.migalhas.com.br/Gramatigalhas/10,MI24539,91041-Como+se+le+8347
    */
    [TestClass]
    public class TesteDePorcentagem
    {
        [DataTestMethod]
        [DataRow(0, "zero por cento")]
        [DataRow(35, "trinta e cinco por cento")]
        [DataRow(1000, "mil por cento")]
        [DataRow(1000000, "um milhão por cento")]
        public string DeveCalcularPorcentagemSimples(int valor)
        {
            return valor.PorExtensoDePorcentagem();
        }

        [DataTestMethod]
        [DataRow(35, "trinta e cinco por cento")]
        [DataRow(1000, "mil por cento")]
        [DataRow(1000000, "um milhão por cento")]
        public string DeveCalcularPorcentagemSimplesParaLong(long valor)
        {
            return valor.PorExtensoDePorcentagem();
        }

        [DataTestMethod]
        [DataRow(83.47, "oitenta e três vírgula quarenta e sete por cento")]
        [DataRow(0.3, "zero vírgula três por cento")]
        [DataRow(78, "setenta e oito por cento")]
        public string DeveEscreverPorExtensoPorcentagemParaDecimal(decimal valor)
        {
            return valor.PorExtensoDePorcentagem();
        }

        [DataTestMethod]
        [DataRow(125.89, "cento e vinte e cinco vírgula oitenta e nove por cento")]
        [DataRow(0.9, "zero vírgula nove por cento")]
        [DataRow(356, "trezentos e cinquenta e seis por cento")]
        public string DeveEscreverPorExtensoPorcentagemParaDouble(double valor)
        {
            return valor.PorExtensoDePorcentagem();
        }

        [TestMethod]
        public void NaoDeveConverterNumeroMaiorQueOSuportado()
        {
            var numeroMaiorQueOMaximo = Convert.ToInt64(new string('9', ConversorDeNumeroParaClasses.NumeroDeClasses * 3 + 1));

            var excecao = Assert.ThrowsException<Exception>(() => numeroMaiorQueOMaximo.PorExtensoDePorcentagem());

            Assert.AreEqual(string.Format("O valor {0} é maior que o suportado pela biblioteca", numeroMaiorQueOMaximo), excecao.Message);
        }

        [TestMethod]
        public void NaoDeveConverterNumeroComMaisDeDuasCasasDecimais()
        {
            const double valor = 0.999;

            var excecao = Assert.ThrowsException<Exception>(() => valor.PorExtensoDePorcentagem());

            Assert.AreEqual(string.Format("O valor {0} tem mais de duas casas decimais", valor), excecao.Message);
        }
    }
}

