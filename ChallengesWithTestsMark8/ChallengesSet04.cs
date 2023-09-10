using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) { result += numbers[i]; }

                if (numbers[i] % 2 != 0) { result -= numbers[i]; }
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int s1 = str1.Length;
            int s2 = str2.Length;
            int s3 = str3.Length;
            int s4 = str4.Length;

            int reslut = Math.Min(Math.Min(Math.Min(s3, s4), s2), s1);

            return reslut;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number1, number2), number3), number4);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 == 0 || sideLength2 == 0 || sideLength3 == 0) { return false; }

            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1) { return true; }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) {return false; }
            if (double.TryParse(input, out _)) { return true; }

            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int result1 = 0;
            int result2 = 0;

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null) { result1++; }
                else { result2++; }
            }

            if (result1 > result2) { return true; }

            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) { return 0; }
            IEnumerable<int> even = numbers.Where(x => x % 2 == 0);

            if (even.Any()) { return even.Average(); }
            return 0;

        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i; 
            }
            return result;
        }
    }
}
