using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(null != words)
            {
                foreach (string word2 in words)
                {
                    if (null != word2)
                    {
                        if (ignoreCase)
                        {
                            if (word2.ToLower().Equals(word.ToLower()))
                                return true;
                        }
                        if (word2.Equals(word))
                            return true;
                    }
                }
            }
            return false;            
        }

        public bool IsPrimeNumber(int num)
        {
            if(num < 2)
                return false;

            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //set index to -1 to return if no uniques
            int index = -1;
            //convert string to char array
            char[] chars = str.ToCharArray();
            //return 0 for string of length 1
            if(str.Length == 1)
                return 0;
            //code for finding index of last unique for strings
            //of length 2 or more
            if (str.Length > 1)
            {
                //test if last letter is unique; return last index if so
                if (chars[str.Length - 1] != chars[str.Length - 2])
                {
                    string let = str.Substring(str.Length - 1);
                    //make sure last letter is unique
                    if(str.IndexOf(let) == str.Length - 1)
                    {
                        return str.Length - 1;
                    }
                }
                    
                if (chars[0] != chars[1])
                    index = 0;

                for (int i = str.Length - 2; i > 0; i--)
                {
                    if (chars[i] != chars[i + 1] && chars[i] != chars[i - 1])
                    {
                        string letter = str.Substring(i, i + 1);
                        if(str.IndexOf(letter) == i)
                            index = i;
                    }
                }      
            }            
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 1;
            int tempCount = 1;
            for (int i = 0; i < numbers.Length -1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    tempCount++;
                }
                else
                {
                    if(tempCount > maxCount)
                    {
                        maxCount = tempCount;                        
                    }
                    tempCount = 1;
                }
            }
            if (tempCount > maxCount)
            {
                maxCount = tempCount;
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if(null == elements || n <= 0 || n > elements.Count)
                return Array.Empty<double>();

            double[] result = new double[elements.Count/n];
            int spot = 0;
            for (int i = n-1; spot < result.Length; i += n)
            {
                result[spot] = elements[i];
                spot++;
            }

            return result;
            
        }
    }
}
