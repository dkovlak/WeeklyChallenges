using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var i in vals)
            {
                if (!i)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) { return false; }

            int result = 0;

            foreach (var i in numbers)
            {
                if (i % 2 != 0)
                {
                    result += i;
                }
            }

            return result % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            bool upper = false;
            bool lower = false;
            bool number = false;

            foreach (char i in password)
            {
                if (char.IsUpper(i))
                {
                    upper = true;
                }

                if (char.IsNumber(i))
                {
                    number = true;
                }

                if (char.IsLower(i))
                {
                    lower = true;
                }
            }

            if (upper && lower && number)
            {
                return true;
            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
             if (string.IsNullOrEmpty(val))
            {
                return '\0';
            }

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                return '\0';
            }

            int i = val.Length - 1;
            return val[i];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0) { return 0; }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums.Length == 0) { return 0; }

            return nums[nums.Length - 1] - nums[0]; 
        }

        public int[] GetOddsBelow100()
        {
            var result = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(i);
                }
            }
            int[] result1 = result.ToArray();
            return result1;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
