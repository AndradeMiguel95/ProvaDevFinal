using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProvaDevFinal.Models;

namespace BaskaraTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double a, b, c;
            Baskara baskara = new Baskara();
            Baskara test1 = new Baskara();
            Larissa.Id = Convert.ToInt32(TestContext.DataRow["id"]);

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
