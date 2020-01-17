using System;
using LengthDemo;

namespace LengthTests
{
    public class Pair
    {
        public LengthUnit From { get; }
        public LengthUnit To { get; }

        public Pair(LengthUnit @from, LengthUnit to)
        {
            From = @from;
            To = to;
        }

        public override bool Equals(object? obj)
        {
            return Equals((Pair)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(From, To); ;
        }

        public bool Equals(Pair pair)
        {
            if (pair == null)
            {
                return true;
            }

            return pair.From == From && pair.To == To;
        }
    }
}