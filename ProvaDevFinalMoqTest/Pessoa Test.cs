using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProvaDevFinal.Models;
using Moq;

namespace ProvaDevFinalMoqTest
{
    [TestClass]
    class PessoaTest
    {

        [TestMethod]
        public void VerificaIdadeTest()
        {
            //Arrange
            Pessoa Miguel = new Pessoa();
            Miguel.Idade = 25;

            Mock<IVerificaIdade> mock = new Mock<IVerificaIdade>();
            mock.Setup(m => m.VerificaIdade(Miguel)).Returns(25 + " é um número primo");

            Pessoa verifica = new Pessoa();

            //Action
            var resultadoEsperado = mock.Object.VerificaIdade(Miguel);
            var resultado = verifica.VerificaIdade(Miguel);

            //Assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }
    }
}