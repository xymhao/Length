using System;
using System.Collections.Generic;
using System.Text;
using LengthDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LengthTests
{
    [TestClass]
    public class UnitTranslateTests
    {
        [TestMethod]
        public void Should_Get_Default_Translate()
        {
            var tanslate = new UnitTranslateInfo();
            tanslate.Add(new Pair(LengthUnit.Feet, LengthUnit.Yard),(double) 1 / 3);
            Assert.AreEqual(1, tanslate.GetCount());
        }

        [TestMethod]
        public void Should_Get_Rate_12_From_Feet_To_Inch()
        {
            var translate = new UnitTranslateInfo();
            translate.Add(new Pair(LengthUnit.Feet, LengthUnit.Inch), (double)12);
            Assert.AreEqual(12, translate.Rate(LengthUnit.Feet, LengthUnit.Inch));
        }

        [TestMethod]
        public void Should_Get_Rate_From_Feet_To_Inch_And_Inch_To_Feet()
        {
            var translate = new UnitTranslateInfo();
            translate.Add(LengthUnit.Feet, LengthUnit.Inch, (double)12);
            Assert.AreEqual(12, translate.Rate(LengthUnit.Feet, LengthUnit.Inch));
            Assert.AreEqual((double)1 / 12, translate.Rate(LengthUnit.Inch, LengthUnit.Feet));
        }

        [TestMethod]
        public void Should_Get_Default_LengthTranslate()
        {
            UnitTranslateInfo translateInfo = UnitTranslateInfo.GetDefault();
            Assert.AreEqual(12, translateInfo.Rate(LengthUnit.Feet, LengthUnit.Inch));
            Assert.AreEqual(36, translateInfo.Rate(LengthUnit.Yard, LengthUnit.Inch));
            Assert.AreEqual(3, translateInfo.Rate(LengthUnit.Yard, LengthUnit.Feet));
        }

        [TestMethod]
        public void Should_Return_1_When_Form_Equals_To()
        {
            var tanslate = new UnitTranslateInfo();
            Assert.AreEqual(1, tanslate.Rate(LengthUnit.Feet, LengthUnit.Feet));
        }
    }
}
