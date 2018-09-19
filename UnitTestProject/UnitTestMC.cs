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
            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void MCPrisMedBrobizz()
        {
            //Arange
            var MC = new Mc();
            //Act
            decimal pris = MC.BrobizzPris();
            //Assert
            Assert.AreEqual(118.75m, pris);
        }

        [TestMethod]
        public void MCKøretøj()
        {
            //Arange
            var MC = new Mc();
            //Act
            string køretøj = MC.Køretøj();
            //Assert
            Assert.AreEqual("MC", køretøj);
        }

        [TestMethod]
        public void MCNummerPladeSyvEllerMinder()
        {
            //Arange
            var MC = new Mc();
            string TestPlade = "DF55200";
            //Act
            MC.NummerPlade = TestPlade;
            //Assert
            Assert.AreEqual(MC.NummerPlade,TestPlade);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MCNummerPladeMereEndSyv()
        {
            //Arange
            var MC = new Mc();
            string TestPlade = "DF552001";
            //Act
            MC.NummerPlade = TestPlade;
            //Assert
            Assert.Fail();
        }
    }
}
