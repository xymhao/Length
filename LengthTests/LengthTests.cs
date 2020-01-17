using LengthDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LengthTests
{
    [TestClass]
    public class LengthTests
    {
        [TestMethod]
        public void Should_2_Feet_Equals_2_Feet()
        {
            Length result = Length.GetFeetLength(2).As(LengthUnit.Feet);
            AssertAsResult(result, 2.0, LengthUnit.Feet);
        }

        [TestMethod]
        public void Should_1_Yard_Equals_1_Yard()
        {
            Length result = Length.GetYardLength(1).As(LengthUnit.Yard);
            AssertAsResult(result, 1.0, LengthUnit.Yard);
        }

        [TestMethod]
        public void Should_1_Foot_Equals_12_Inches()
        {
            Length result = Length.GetFeetLength(1).As(LengthUnit.Inch);
            AssertAsResult(result, 12.0, LengthUnit.Inch);
        }

        [TestMethod]
        public void Should_3_Foot_Equals_1_Yard()
        {
            Length result = Length.GetFeetLength(3).As(LengthUnit.Yard);
            AssertAsResult(result, 1.0, LengthUnit.Yard);
        }

        [TestMethod]
        public void Should_1_Yard_Equals_3_Feet()
        {
            Length result = Length.GetYardLength(1).As(LengthUnit.Feet);
            AssertAsResult(result, 3.0, LengthUnit.Feet);
        }

        [TestMethod]
        public void Should_1_Yard_Equals_36_Inches()
        {
            Length result = Length.GetYardLength(1).As(LengthUnit.Inch);
            AssertAsResult(result, 36.0, LengthUnit.Inch);
        }

        [TestMethod]
        public void Should_2_yards_Equals_72_Inches()
        {
            Length result = Length.GetYardLength(2).As(LengthUnit.Inch);

            Assert.AreEqual(result.GetVal(), (72.0));
            Assert.AreEqual(result.GetUint(), LengthUnit.Inch);
        }

        [TestMethod]
        public void Should_12_Inches_Equals_1_Foot()
        {
            Length result = Length.GetInchLength(12).As(LengthUnit.Feet);

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), LengthUnit.Feet);
        }

        [TestMethod]
        public void Should_36_Inches_Equals_1_Yard()
        {
            Length result = Length.GetInchLength(36).As(LengthUnit.Yard);

            Assert.AreEqual(result.GetVal(), (1.0));
            Assert.AreEqual(result.GetUint(), LengthUnit.Yard);
        }

        [TestMethod]
        public void Should_18_Inches_Equals_Half_Yard()
        {
            Length result = Length.GetInchLength(18).As(LengthUnit.Yard);
            Assert.AreEqual(result.GetVal(), (0.5));
            Assert.AreEqual(result.GetUint(), LengthUnit.Yard);
        }

        private static void AssertAsResult(Length result, double expected, LengthUnit lengthUnit)
        {
            Assert.AreEqual(expected, result.GetVal());
            Assert.AreEqual(lengthUnit, result.GetUint());
        }
    }
}
