using System;

namespace LengthDemo
{
    public class Length
    {
        private const string Feet = "feet";
        private const string Yard = "yard";
        private const string Inch = "inch";
        private readonly double value;
        private readonly string unit;

        public Length(double lengthValue, string uintValue)
        {
            value = lengthValue;
            unit = uintValue;
        }


        public Length As(string targetUnit)
        {
            if (targetUnit.Equals(Unit.Inch.ToString(), StringComparison.CurrentCultureIgnoreCase))
            {
                return As(targetUnit, Unit.Inch);
            }

            if (targetUnit.Equals(Unit.Feet.ToString(), StringComparison.CurrentCultureIgnoreCase))
            {
                return As(targetUnit, Unit.Feet);
            }

            if (targetUnit.Equals(Unit.Yard.ToString(), StringComparison.CurrentCultureIgnoreCase))
            {
                return As(targetUnit, Unit.Yard);
            }
            return As(targetUnit, null);
        }

        public Length As(string toUnit, Unit? toUnitEnum)
        {
            Length length = this;
            if (unit.Equals(Feet))
            {
                if (toUnitEnum.Equals(Unit.Yard))
                {
                    length = new Length(value / 3, toUnit);
                }
                else if (toUnitEnum.Equals(Unit.Inch))
                {
                    length = new Length(value * 12, toUnit);
                }
            }

            if (unit.Equals(Yard))
            {
                if (toUnitEnum.Equals(Unit.Inch))
                {
                    length = new Length(value * 36, toUnit);
                }
                else if (toUnitEnum.Equals(Unit.Feet))
                {
                    length = new Length(value * 3, toUnit);
                }
            }

            if (unit.Equals(Inch))
            {
                if (toUnitEnum.Equals(Unit.Feet))
                {
                    length = new Length(value / 12, toUnit);
                }
                else if (toUnitEnum.Equals(Unit.Yard))
                {
                    length = new Length(value / 36, toUnit);
                }
            }

            return length;
        }

        public double GetVal()
        {
            return value;
        }

        public string GetUint()
        {
            return unit;
        }
    }

    public enum Unit
    {
        Inch = 1,
        Feet =12,
        Yard = 36
    }
}
