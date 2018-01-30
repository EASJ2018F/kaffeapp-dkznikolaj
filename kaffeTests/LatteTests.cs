using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests
{
    [TestClass()]
    public class LatteTests
    {
        [TestMethod()]
        public void LattePrisTest()
        {
            //Arrange
            var latte = new Latte();

            //Act
            int pris = latte.Pris();

            //assert
            Assert.AreEqual(40, pris);

        }
    }
}