using System;
using System.Collections.Generic;
using SD_21_ARE_POWERS_EQUAL_TO_OTHER_LIST_LINQ;
using Xunit;

namespace SD_21_ARE_POWERS_EQUAL_TO_OTHER_LIST_LINQ_TESTS
{
    public class AllTests
    {
        [Theory(DisplayName ="ArePowersEqualTo?")]
        [InlineData(new int[] { 2, 2, 2 }, new int[] { 4, 4, 4 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 4, 9, 16, 25 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 2, 9, 16, 25 }, false)]
        [InlineData(new int[] { 132, 22, 3185, 485, 512 }, new int[] { 232, 215, 998, 168, 254 }, false)]
        public static void ArePowersEqualTo_Should_ReturnBool(IEnumerable<int> left, IEnumerable<int> right, bool result)
        {
            var expected = result;


            var actual = left.ArePowersEqualTo(right);

            Assert.True(expected.Equals(actual));
        }


    }
}
