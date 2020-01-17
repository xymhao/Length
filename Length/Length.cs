using System;
using LengthTests;

namespace LengthDemo
{
    public class Length
    {
        //1 feet(英尺) = 12 inch（英寸）
        //1 yard（码） = 36 inch
        //1 yard = 3 feet
        private readonly double value;
        private readonly LengthUnit unit;
        private UnitTranslateInfo TranslateInfo { get; }

        public Length(double val, LengthUnit uinnt, UnitTranslateInfo translateInfo = null)
        {
            value = val;
            unit = uinnt;
            TranslateInfo = translateInfo ?? UnitTranslateInfo.GetDefault();
        }

        public static Length GetFeetLength(double val)
        {
            var feetLength = new Length(val, LengthUnit.Feet);
            return feetLength;
        }

        public static Length GetYardLength(double val)
        {
            return new Length(val, LengthUnit.Yard);
        }

        public static Length GetInchLength(double val)
        {
            return new Length(val, LengthUnit.Inch);
        }

        public Length As(LengthUnit toUnit)
        {
            var rate = TranslateInfo.Rate(unit, toUnit);
            var len = new Length((value * rate), toUnit);
            return len;
        }

        public double GetVal()
        {
            return value;
        }

        public LengthUnit GetUint()
        {
            return unit;
        }
    }
}
