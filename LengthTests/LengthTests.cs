using LengthDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LengthTests
{
    [TestClass]
    public class LengthTests
    {
        [TestMethod]
        public void Should_1_Inch_Equals_1_Inch()
        {
            Length result = new Length(1, "inch").As("inch");

            Assert.AreEqual(result.getVal(), (1.0));
            Assert.AreEqual(result.getUinnt(), ("inch"));
        }

        [TestMethod]
        public void Should_2_Feet_Equals_2_Feet()
        {
            Length result = new Length(2, "f").As("f");

            Assert.AreEqual(result.getVal(), (2.0));
            Assert.AreEqual(result.getUinnt(), ("f"));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_1_Yard()
        {
            Length result = new Length(1, "yard").As("yard");

            Assert.AreEqual(result.getVal(), (1.0));
            Assert.AreEqual(result.getUinnt(), ("yard"));
        }

        [TestMethod]
        public void Should_1_foot_equals_12_inches()
        {
            Length result = new Length(1, "f").As("inch");

            Assert.AreEqual(result.getVal(), (12.0));
            Assert.AreEqual(result.getUinnt(), ("inch"));
        }

        [TestMethod]
        public void Should_3_foot_equals_1_yard()
        {
            Length result = new Length(3, "f").As("yard");

            Assert.AreEqual(result.getVal(), (1.0));
            Assert.AreEqual(result.getUinnt(), ("yard"));
        }

        [TestMethod]
        public void Should_1_yard_equals_3_feet()
        {
            Length result = new Length(1, "yard").As("f");

            Assert.AreEqual(result.getVal(), (3.0));
            Assert.AreEqual(result.getUinnt(), ("f"));
        }

        [TestMethod]
        public void Should_1_yard_equals_36_inches()
        {
            Length result = new Length(1, "yard").As("inch");

            Assert.AreEqual(result.getVal(), (36.0));
            Assert.AreEqual(result.getUinnt(), ("inch"));
        }

        [TestMethod]
        public void Should_2_yards_equals_72_inches()
        {
            Length result = new Length(2, "yard").As("inch");

            Assert.AreEqual(result.getVal(), (72.0));
            Assert.AreEqual(result.getUinnt(), ("inch"));
        }

        [TestMethod]
        public void Should_12_inches_equals_1_foot()
        {
            Length result = new Length(12, "inch").As("f");

            Assert.AreEqual(result.getVal(), (1.0));
            Assert.AreEqual(result.getUinnt(), ("f"));
        }

        [TestMethod]
        public void Should_36_inches_equals_1_Yard()
        {
            Length result = new Length(36, "inch").As("yard");

            Assert.AreEqual(result.getVal(), (1.0));
            Assert.AreEqual(result.getUinnt(), ("yard"));
        }

        [TestMethod]
        public void Should_18_Inches_Equals_Half_Yard()
        {
            Length result = new Length(18, "inch").As("yard");

            Assert.AreEqual(result.getVal(), (0.5));
            Assert.AreEqual(result.getUinnt(), ("yard"));
        }
    }
}
