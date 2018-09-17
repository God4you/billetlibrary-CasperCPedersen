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
    public class UnitTestMC
    {
        [TestMethod]
        public void MCPris()
        {
            //Arange
            var MC = new Mc();
            //Act
            decimal pris = MC.Pris();
            //Assort
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void BilKøretøj()
        {
            //Arange
            var MC = new Mc();
            //Act
            string køretøj = MC.Køretøj();
            //Assort
            Assert.AreEqual("MC", køretøj);
        }
    }
}
