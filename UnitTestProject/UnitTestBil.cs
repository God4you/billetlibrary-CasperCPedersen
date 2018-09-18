using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    /// <summary>
    /// Unit Test Class Runs Unit test on "Bil" Class.
    /// </summary>
    [TestClass]
    public class UnitTestBil
    {
        /// <summary>
        /// Tester Bil.pris() method = 240
        /// </summary>
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
        /// <summary>
        /// Tester Bil.BilprisMedBrobizz() method = Pris()-5%
        /// </summary>
        [TestMethod]
        public void BilPrisMedBrobizz()
        {
            //Arange
            var bil = new Bil();
            //Act
            decimal pris = bil.BrobizzPris();
            //Assort
            Assert.AreEqual(228, pris);
        }
        /// <summary>
        /// Tester Bil.Køretøj() method = Bil
        /// </summary>
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
        /// <summary>
        /// Tester Bil.NummerPaldeLæser() method. accpeter nummerplade minder end 7 tengn
        /// </summary>
        [TestMethod]
        public void BilNummerPladeMinderEndSyv()
        {
            //Arange
            var bil = new Bil();
            string TestPlade = "DF55200";
            //Act
            string Svar = bil.NummerPladeLæser(TestPlade);
            //Assort
            Assert.AreEqual("Nummerplade er godtaget",Svar);
        }
        /// <summary>
        /// Tester Bil.NummerPaldeLæser() method. ikke accpeter nummerplade mere end 7 tengn
        /// </summary>
        [TestMethod]
        public void BilNummerPladeMereEndSyv()
        {
            //Arange
            var bil = new Bil();
            string TestPlade = "DF552001";
            //Act
            string Svar = bil.NummerPladeLæser(TestPlade);
            //Assort
            Assert.AreEqual("Fejl: Nummerlade for lang", Svar);
        }

    }
}
