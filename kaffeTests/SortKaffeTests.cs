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
    public class SortKaffeTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void SortKaffePrisTestForMegetRabat20kr()
        {
            //Arrange
            var sortKaffe = new SortKaffe(20);

            //Act
            int pris = sortKaffe.Pris();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void SortKaffePrisTestForMegetRabat21kr()
        {
            //Arrange
            var sortKaffe = new SortKaffe(21);

            //Act
            int pris = sortKaffe.Pris();
        }

        /// <summary>
        /// Rabatten skal være 0 når default ctor kaldes
        /// </summary>
        [TestMethod]
        public void SortKaffeDefaultConstructorRabat()
        {
            //Arrange
            var sortKaffe = new SortKaffe();

            //Act
            sortKaffe.Styrke();

            //Assert
            Assert.AreEqual(sortKaffe.Rabat, 0);

        }

    }
}