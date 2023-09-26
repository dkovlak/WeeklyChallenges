using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            if (ignoreCase) { return words.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase)); }

            return words.Contains(word);
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) { return false; }

            else if (num == 2 || num == 3) { return true; }

            else if (num % 3 == 0 || num % 2 == 0) { return false; }

            else
            {
                return true;
            }

        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var charIndexMap = new Dictionary<char, int>();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];

                if (!charIndexMap.ContainsKey(c))
                {
                    charIndexMap[c] = i;
                }
                else
                {
                    charIndexMap[c] = -1; 
                }
            }

            int lastIndex = -1;

            foreach (var kvp in charIndexMap)
            {
                if (kvp.Value != -1 && lastIndex == -1)
                {
                    lastIndex = kvp.Value; 
                }
            }

            return lastIndex;
        }


        public int MaxConsecutiveCount(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0) { return 0; }

            int count = 1;
            int max = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[--i]) { count++; }
                else
                {
                    count = 1;
                }
                if (count > max)
                {
                    max = count;
                }
            }

            return max;
        }


        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n <= 0 || elements == null) { return new double[] { }; }

            var result = new List<double>();

            for (int i = n-1; i < elements.Count; i+=n)
            {
                    result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
