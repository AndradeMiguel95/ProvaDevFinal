using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProvaDevFinal.Models;

namespace ProvaDevFinalTest
{
    [TestClass]
    public class BaskaraTest
    {
        [DataRow(3, 5, 8, -1)]
        [DataRow(1, 2, 1, 0)]
        [DataRow(1, 2, 15, -1)]
        [TestMethod]
        public void TestBaskara (double a1, double b1, double c1, double resultadoteste)
        {
            //Arrange
            double resultado;
            Baskara BaskaraTest = new Baskara();

            //Action
            resultado = BaskaraTest.Bhaskara1(a1, b1, c1);

            //Assert
            Assert.AreEqual(resultado, resultadoteste);
        }
    }
}
