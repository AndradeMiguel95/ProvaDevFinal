using System;
using Xunit;
using ProvaDevFinal.Models;
using Moq;

namespace ProvaDevFinalTestMoq
{
    public class PessoaTest
    {
        [Fact]
        public void VerificaIdadeTest1()
        {
            //Arrange
            Pessoa Miguel = new Pessoa();
            Miguel.Idade = 17;

            Mock<IVerificaIdade> mock = new Mock<IVerificaIdade>();
            mock.Setup(m => m.VerificaIdade(Miguel)).Returns(17 + " é um número primo");

            Pessoa verifica = new Pessoa();

            //Action
            var resultadoEsperado = mock.Object.VerificaIdade(Miguel);
            var resultado = verifica.VerificaIdade(Miguel);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }
        [Fact]
        public void VerificaIdadeTest2()
        {
            //Arrange
            Pessoa Miguel = new Pessoa();
            Miguel.Idade = 18;

            Mock<IVerificaIdade> mock = new Mock<IVerificaIdade>();
            mock.Setup(m => m.VerificaIdade(Miguel)).Returns(18 + " não é um número primo");

            Pessoa verifica = new Pessoa();

            //Action
            var resultadoEsperado = mock.Object.VerificaIdade(Miguel);
            var resultado = verifica.VerificaIdade(Miguel);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }
        [Fact]
        public void VerificaIdadeTest3()
        {
            //Arrange
            Pessoa Miguel = new Pessoa();
            Miguel.Idade = 19;

            Mock<IVerificaIdade> mock = new Mock<IVerificaIdade>();
            mock.Setup(m => m.VerificaIdade(Miguel)).Returns(19 + " é um número primo");

            Pessoa verifica = new Pessoa();

            //Action
            var resultadoEsperado = mock.Object.VerificaIdade(Miguel);
            var resultado = verifica.VerificaIdade(Miguel);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }
        [Fact]
        public void VerificaIdadeTest4()
        {
            //Arrange
            Pessoa Miguel = new Pessoa();
            Miguel.Idade = 20;

            Mock<IVerificaIdade> mock = new Mock<IVerificaIdade>();
            mock.Setup(m => m.VerificaIdade(Miguel)).Returns(20 + " não é um número primo");

            Pessoa verifica = new Pessoa();

            //Action
            var resultadoEsperado = mock.Object.VerificaIdade(Miguel);
            var resultado = verifica.VerificaIdade(Miguel);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }
    }
}
