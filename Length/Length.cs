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

        public Length As(string toUnit)
        {
            Length len = this;
            if (unit.Equals(Feet))
            {
                if (toUnit.Equals(Yard))
                {
                    len = new Length(value / 3, toUnit);
                }
                else if (toUnit.Equals(Inch))
                {
                    len = new Length(value * 12, toUnit);
                }
            }

            if (unit.Equals(Yard))
            {
                if (toUnit.Equals(Inch))
                {
                    len = new Length(value * 36, toUnit);
                }
                else if (toUnit.Equals(Feet))
                {
                    len = new Length(value * 3, toUnit);
                }
            }

            if (unit.Equals(Inch))
            {
                if (toUnit.Equals(Feet))
                {
                    len = new Length(value / 12, toUnit);
                }
                else if (toUnit.Equals(Yard))
                {
                    len = new Length(value / 36, toUnit);
                }
            }

            return len;
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
}
