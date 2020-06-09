using System;

namespace SD_21_ARE_POWERS_EQUAL_TO_OTHER_LIST_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var squares = new int[] { 1, 4, 9, 16, 25 };
            var areEqual = numbers.ArePowersEqualTo(squares);
            Console.WriteLine(string.Concat("Working example returns ",areEqual));

            var wrongNumbers = new int[] { 1, 2, 3, 4, 5 };
            var wrongSquares = new int[] { 2, 2, 9, 16, 25 };
            var areEqual2 = wrongNumbers.ArePowersEqualTo(wrongSquares);
            Console.WriteLine(string.Concat("Wrong example returns ",areEqual2));
    

            Console.WriteLine("Program ended");
        }
    }
}
