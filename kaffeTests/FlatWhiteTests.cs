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
    public class FlatWhiteTests
    {
        /// <summary>
        /// Checks the price
        /// </summary>
        [TestMethod]
        public void FlatWhiteKaffePris()
        {
            //Arrange
            var flatWhite = new FlatWhite();

            //Act
            int pris = flatWhite.Pris();

            //Assert
            Assert.AreEqual(45, pris);

        }

        /// <summary>
        /// Checks the quantity of milk
        /// </summary>
        [TestMethod]
        public void FlatWhiteKaffeMLmælk()
        {
            //Arrange
            var flatWhite = new FlatWhite();

            //Act
            int mlMælk = flatWhite.MlMælk();

            //Assert
            Assert.AreEqual(160, mlMælk);

        }

        /// <summary>
        /// Tests the strength
        /// </summary>
        [TestMethod]
        public void FlatWhiteKaffestyrke()
        {
            //Arrange
            var flatWhite = new FlatWhite();

            //Act
            string styrke = flatWhite.Styrke();

            //Assert
            Assert.AreEqual("Mild", styrke);

        }

    }
}