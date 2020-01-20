using LengthDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LengthTests
{
    [TestClass]
    public class LengthTests
    {
        private const string Inch = "inch";
        private const string Feet = "feet";
        private const string Yard = "yard";

        [TestMethod]
        public void Should_1_Inch_Equals_1_Inch()
        {
            Length result = new Length(1, Inch).As(Inch, Unit.Inch);

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), (Inch));
        }

        [TestMethod]
        public void Should_2_Feet_Equals_2_Feet()
        {
            Length result = new Length(2, Feet).As(Feet, Unit.Feet);

            Assert.AreEqual(result.GetVal(), (2.0));
            Assert.AreEqual(result.GetUint(), (Feet));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_1_Yard()
        {
            Length result = new Length(1, Yard).As(Yard,  Unit.Yard);

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), (Yard));
        }

        [TestMethod]
        public void Should_1_Foot_Equals_12_Inches()
        {
            Length result = new Length(1, Feet).As(Inch, Unit.Inch);

            Assert.AreEqual(result.GetVal(), (12.0));
            Assert.AreEqual(result.GetUint(), (Inch));
        }

        [TestMethod]
        public void Should_3_Foot_Equals_1_Yard()
        {
            Length result = new Length(3, Feet).As(Yard, Unit.Yard);

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), (Yard));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_3_Feet()
        {
            Length result = new Length(1, Yard).As(Feet, Unit.Feet);

            Assert.AreEqual(result.GetVal(), (3.0));
            Assert.AreEqual(result.GetUint(), (Feet));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_36_Inches()
        {
            Length result = new Length(1, Yard).As(Inch,Unit.Inch);

            Assert.AreEqual(result.GetVal(), (36.0));
            Assert.AreEqual(result.GetUint(), (Inch));
        }

        [TestMethod]
        public void Should_2_yards_Equals_72_Inches()
        {
            Length result = new Length(2, Yard).As(Inch, Unit.Inch);

            Assert.AreEqual(result.GetVal(), (72.0));
            Assert.AreEqual(result.GetUint(), (Inch));
        }

        [TestMethod]
        public void Should_12_Inches_Equals_1_Foot()
        {
            Length result = new Length(12, Inch).As(Feet, Unit.Feet);

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), (Feet));
        }

        [TestMethod]
        public void Should_36_Inches_Equals_1_Yard()
        {
            Length result = new Length(36, Inch).As(Yard, Unit.Yard);

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), (Yard));
        }

        [TestMethod]
        public void Should_18_Inches_Equals_Half_Yard()
        {
            Length result = new Length(18, Inch).As(Yard, Unit.Yard);

            Assert.AreEqual(result.GetVal(), (0.5));
            Assert.AreEqual(result.GetUint(), (Yard));
        }
    }
}
