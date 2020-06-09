using System;
using System.Collections.Generic;
using System.Text;

namespace SD_21_ARE_POWERS_EQUAL_TO_OTHER_LIST_LINQ
{
    public static class Extensions
    {

        public static bool ArePowersEqualTo(
            this IEnumerable<int> left, IEnumerable<int> right)
        {
            var leftIterator = left.GetEnumerator();
            var rightIterator = right.GetEnumerator();

            while (leftIterator.MoveNext() && rightIterator.MoveNext())
            {
                if (!Math.Pow(leftIterator.Current, 2).Equals(rightIterator.Current))


                    return false;
            }


            return true;
        }
    }
}
