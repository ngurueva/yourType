using Microsoft.VisualStudio.TestTools.UnitTesting;
using СвойТип;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СвойТип.Tests
{
    [TestClass()]
    public class FractionTests
    {

        [TestMethod()]
        public void VerboseTest()
        {
            var fraction = new Fraction(0, 1, 2);
            Assert.AreEqual("0 1 2", fraction.Verbose());
        }

        [TestMethod()]
        public void ValidTest()
        {
            var fraction = new Fraction(0, 1, 2);
            Assert.AreEqual(true, fraction.IsFractionValid());
        }
        [TestMethod()]
        public void NoValidTest()
        {
            var fraction = new Fraction(0, 3, 1);
            Assert.AreEqual(false, fraction.IsFractionValid());
        }


        [TestMethod()]
        public void AddNumberTest1()
        {
            var fraction1 = new Fraction(2, 1, 3);
            var fraction2 = new Fraction(3, 1, 3);
            var fraction = fraction1 + fraction2;
            Assert.AreEqual("5 2 3", fraction.Verbose());
        }
        [TestMethod()]
        public void multipliedNumberTest1()
        {
            var fraction1 = new Fraction(2, 1, 3);
            var fraction2 = new Fraction(3, 2, 4);
            var fraction = fraction1 * fraction2;
            Assert.AreEqual("8 1 6", fraction.Verbose());
        }

        [TestMethod()]
        public void divideNumberTest1()
        {
            var fraction1 = new Fraction(2, 1, 3);
            var fraction2 = new Fraction(3, 2, 4);
            var fraction = fraction1 / fraction2;
            Assert.AreEqual("0 2 3", fraction.Verbose());
        }

        [TestMethod()]
        public void compareNumberTest1()
        {
            var fraction1 = new Fraction(2, 1, 3);
            var fraction2 = new Fraction(3, 2, 4);
            var fraction = fraction1 > fraction2;
            Assert.AreEqual(false, fraction);
        }
    }
}