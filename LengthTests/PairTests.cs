using System;
using System.Collections.Generic;
using System.Text;
using LengthDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LengthTests
{
    [TestClass]
    public class PairTests
    {
        [TestMethod]
        public void Should_Add_Pair()
        {
            var pair = new Pair(LengthUnit.Yard, LengthUnit.Feet);
            Assert.AreEqual(LengthUnit.Yard, pair.From);
            Assert.AreEqual(LengthUnit.Feet, pair.To);
        }

        [TestMethod]
        public void Should_Override_Equals()
        {
            var pair = new Pair(LengthUnit.Yard, LengthUnit.Feet);
            var pair2 = new Pair(LengthUnit.Yard, LengthUnit.Feet);
            Assert.AreEqual(pair, pair2);
        }
    }
}
