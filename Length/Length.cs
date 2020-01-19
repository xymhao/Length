using System;

namespace LengthDemo
{
    public class Length
    {
        private readonly double value;
        private readonly string unit;

        public Length(double val, string uintVal)
        {
            value = val;
            unit = uintVal;
        }

        public Length As(string u)
        {
            Length len = this;
            if (unit.Equals("f"))
            {
                if (u.Equals("yard"))
                {
                    len = new Length(value / 3, u);
                }
                else if (u.Equals("inch"))
                {
                    len = new Length(value * 12, u);
                }
            }

            if (unit.Equals("yard"))
            {
                if (u.Equals("inch"))
                {
                    len = new Length(value * 36, u);
                }
                else if (u.Equals("f"))
                {
                    len = new Length(value * 3, u);
                }
            }

            if (unit.Equals("inch"))
            {
                if (u.Equals("f"))
                {
                    len = new Length(value / 12, u);
                }
                else if (u.Equals("yard"))
                {
                    len = new Length(value / 36, u);
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
