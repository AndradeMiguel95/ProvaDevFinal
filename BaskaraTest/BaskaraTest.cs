using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 
using ProvaDevFinal.Models;

namespace BaskaraTest
{
    [TestClass]
    public class BaskaraTest
    {
        [DataRow(3, 5, 8)]
        [DataRow(2, 7, 9)]
        [DataRow(10, 5, 15)]
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double resultado;
            Baskara BaskaraTest = new Baskara();

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaId(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var idEsperado = mock.Object.VerificaId(Larissa);
            var id = verifica.VerificaId(Larissa);

            //Assert
            Assert.AreEqual(id, idEsperado);
        }
    }
}
