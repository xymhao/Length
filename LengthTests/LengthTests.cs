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

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), ("inch"));
        }

        [TestMethod]
        public void Should_2_Feet_Equals_2_Feet()
        {
            Length result = new Length(2, "f").As("f");

            Assert.AreEqual(result.GetVal(), (2.0));
            Assert.AreEqual(result.GetUint(), ("f"));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_1_Yard()
        {
            Length result = new Length(1, "yard").As("yard");

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), ("yard"));
        }

        [TestMethod]
        public void Should_1_Foot_Equals_12_Inches()
        {
            Length result = new Length(1, "f").As("inch");

            Assert.AreEqual(result.GetVal(), (12.0));
            Assert.AreEqual(result.GetUint(), ("inch"));
        }

        [TestMethod]
        public void Should_3_Foot_Equals_1_Yard()
        {
            Length result = new Length(3, "f").As("yard");

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), ("yard"));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_3_Feet()
        {
            Length result = new Length(1, "yard").As("f");

            Assert.AreEqual(result.GetVal(), (3.0));
            Assert.AreEqual(result.GetUint(), ("f"));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_36_Inches()
        {
            Length result = new Length(1, "yard").As("inch");

            Assert.AreEqual(result.GetVal(), (36.0));
            Assert.AreEqual(result.GetUint(), ("inch"));
        }

        [TestMethod]
        public void Should_2_yards_Equals_72_Inches()
        {
            Length result = new Length(2, "yard").As("inch");

            Assert.AreEqual(result.GetVal(), (72.0));
            Assert.AreEqual(result.GetUint(), ("inch"));
        }

        [TestMethod]
        public void Should_12_Inches_Equals_1_Foot()
        {
            Length result = new Length(12, "inch").As("f");

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), ("f"));
        }

        [TestMethod]
        public void Should_36_Inches_Equals_1_Yard()
        {
            Length result = new Length(36, "inch").As("yard");

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), ("yard"));
        }

        [TestMethod]
        public void Should_18_Inches_Equals_Half_Yard()
        {
            Length result = new Length(18, "inch").As("yard");

            Assert.AreEqual(result.GetVal(), (0.5));
            Assert.AreEqual(result.GetUint(), ("yard"));
        }
    }
}
