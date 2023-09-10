using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n <= 0) { throw new ArgumentException(); }

            if (startNumber < 0) { startNumber = 0;}

            startNumber++;

           while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            if (businesses == null) { return; }

            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0) { businesses[i].Name = "CLOSED"; }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return false; }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i+1]) { return false; }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return 0; }

            int result = 0;
            int previousNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (previousNumber % 2 == 0)
                {
                    result += numbers[i];
                }

                previousNumber = numbers[i];
            }

            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";

            foreach (var i in words)
            {
                if(i.Trim().Length > 0)
                {
                    sentence += i.Trim() + " ";
                }

                
            }

            if (sentence.Length == 0) { return ""; }

            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) { return new double[0]; }

            var result = new List<double>();

            for (int i = 3; i < elements.Count; i+=4)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber) { return true; }
                }
            }
            return false;
        }
    }
}
