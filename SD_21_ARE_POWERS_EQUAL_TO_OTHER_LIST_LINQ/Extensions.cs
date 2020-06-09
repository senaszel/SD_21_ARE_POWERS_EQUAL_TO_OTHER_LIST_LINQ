using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SD_21_ARE_POWERS_EQUAL_TO_OTHER_LIST_LINQ
{
    public static class Extensions
    {

        public static bool ArePowersEqualTo<T>(
            this IEnumerable<T> left, IEnumerable<T> right)
        {
            var lefter = left.Select(
                x => Math.Pow(Convert.ToDouble(x), 2))
                .AsParallel();


            var righter = Array.ConvertAll(
                right.ToArray(), element => Convert.ToDouble(element))
                .AsParallel();


            return lefter.SequenceEqual(righter);
        }

    }
}
