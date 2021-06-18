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
        public void TestBaskara(double a, double b, double c, double resultadoteste)
        {
            //Arrange
            double resultado;
            Baskara BaskaraTest = new Baskara();

            //Action
            resultado = BaskaraTest.Bhaskara1(a, b, c);

            //Assert
            Assert.AreEqual(resultado, resultadoteste);
        }
    }
}