using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null))
            {
                return false;
            }

            if(ignoreCase )
            {

                foreach (var w in words)
                {
                    if(w.ToLower() == word.ToLower())
                    {

                        return true;
                    }
                }

            }
          
                return words.Contains(word);
            
        }

    public bool IsPrimeNumber(int num)
        {
            //throw new NotImplementedException();
            if (num == 2)
            {
                return true;
            }
            else if (num <= 1)

            {
                return false;
            }

            var limit = Math.Ceiling(Math.Sqrt(num));

            for (var i = 2; i <= limit; ++i)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            // throw new NotImplementedException();
            if (str.Length == 1)
            {
                return 0;
            }
            if (str == "")
            {
                return -1;
            }

            var counter = 0;

            var answer = 0;

            var count = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                foreach (var lett in str)
                {
                    if (str[i] == lett)
                    {
                        count[i]++;
                    }
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (count[i] == 1)
                {
                    answer = i;
                }
                else if (count[i] > 1)
                {
                    counter++;
                }
            }

            if (counter == str.Length)
            {
                return -1;
            }

            return answer;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var totalCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;

                }

                if (currentCount > totalCount)
                {
                    totalCount = currentCount;
                }
            }

            return totalCount;

        }
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();

            double[] nullCheck = new double[0];

            if (elements == null)
            {
                return nullCheck;
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }

                if (n < 0 || n > elements.Count)
                {
                    nthElement.Clear();
                }
            }

            double[] finalArray = nthElement.ToArray();

            return finalArray;
        }


    }
}