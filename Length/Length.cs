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
            Length length = this;
            if (unit.Equals(Unit.Feet))
            {
                if (targetUnit.Equals(Unit.Yard))
                {
                    length = new Length(value / 3, targetUnit);
                }
                else if (targetUnit.Equals(Unit.Inch))
                {
                    length = new Length(value * 12, targetUnit);
                }
            }

            if (unit.Equals(Unit.Yard))
            {
                if (targetUnit.Equals(Unit.Inch))
                {
                    length = new Length(value * 36, targetUnit);
                }
                else if (targetUnit.Equals(Unit.Feet))
                {
                    length = new Length(value * 3, targetUnit);
                }
            }

            if (unit.Equals(Unit.Inch))
            {
                if (targetUnit.Equals(Unit.Feet))
                {
                    length = new Length(value / 12, targetUnit);
                }
                else if (targetUnit.Equals(Unit.Yard))
                {
                    length = new Length(value / 36, targetUnit);
                }
            }

            return length;
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
