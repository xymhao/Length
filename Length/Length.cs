using System;

namespace LengthDemo
{
    public class Length
    {
        private readonly double value;
        private readonly Unit unit;

        public Length(double lengthValue, Unit toUnitEnum)
        {
            value = lengthValue;
            unit = toUnitEnum;
        }

        public Length As(Unit targetUnit)
        {
            var temValue = value * (int)unit / (int)targetUnit;
            return new Length(temValue, targetUnit);
        }

        public double GetVal()
        {
            return value;
        }

        public Enum GetUint()
        {
            return unit;
        }
    }
}
