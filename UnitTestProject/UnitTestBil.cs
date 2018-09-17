using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestBil
    {
        [TestMethod]
        public void BilPris()
        {
            //Arange
            var bil = new Bil();
            //Act
            decimal pris = bil.Pris();
            //Assort
            Assert.AreEqual(240,pris);
        }

        [TestMethod]
        public void BilKøretøj()
        {
            //Arange
            var bil = new Bil();
            //Act
            string køretøj = bil.Køretøj();
            //Assort
            Assert.AreEqual("Bil",køretøj);
        }
    }
}
