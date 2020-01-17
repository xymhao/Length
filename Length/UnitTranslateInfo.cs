using System;
using System.Collections;
using System.Collections.Generic;
using LengthDemo;

namespace LengthTests
{
    public class UnitTranslateInfo
    {
        private readonly Hashtable _hashtable = new Hashtable();


        public int GetCount()
        {
            return _hashtable.Count;
        }

        public void Add(Pair pair, double rate)
        {
            _hashtable.Add(pair, rate);
        }


        public double Rate(LengthUnit from, LengthUnit to)
        {
            if (from.Equals(to))
            {
                return 1;
            }
            var rate = (double?)_hashtable[new Pair(@from, to)];
            if (rate == null)
            {
                throw new ArgumentException("未获取到比率。");
            }
            return rate.Value;
        }

        public void Add(LengthUnit from, LengthUnit to, double rate)
        {
            Add(new Pair(from, to), rate);
            Add(new Pair(to, from), 1/rate);
        }

        public static UnitTranslateInfo GetDefault()
        {
            var translate = new UnitTranslateInfo();
            translate.Add(LengthUnit.Feet,LengthUnit.Inch, 12);
            translate.Add(LengthUnit.Yard,LengthUnit.Inch, 36);
            translate.Add(LengthUnit.Yard,LengthUnit.Feet, 3);
            return translate;
        }
    }
}