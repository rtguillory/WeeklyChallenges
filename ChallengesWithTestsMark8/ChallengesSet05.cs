using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int i = startNumber + 1;
            while(i%n != 0)
            {
                i++;
            }
            return i;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {
                if(businesses[i] != null)
                {
                    if(businesses[i].TotalRevenue == 0)
                    {
                        businesses[i].Name = "CLOSED";
                    }
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(null == numbers || numbers.Length == 0  )
            {
                return false;
            }
            for(int i =0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i+1]) 
                { return false; }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (null == numbers || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for(int i = 0;i < numbers.Length - 1; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sum+= numbers[i+1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (null == words || words.Length == 0)
                return "";
            string sentence = words[0];
            for(int i = 1; i<words.Length; i++)
            {
                sentence = sentence.Trim();
                sentence += $" {words[i].Trim()}";
            }
            sentence = sentence.Trim();
            if(sentence.Length > 0)
                sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (null == elements || elements.Count == 0)
            {
                return Array.Empty<double>();
            }

            double[] fourthElements = new double[elements.Count / 4];
                            
            int spot = 0;
            for (int i = 3; spot < fourthElements.Length; i += 4)
            {
                fourthElements[spot] = elements[i];
                spot++;
            }
            return fourthElements;

        }
 

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                        return true;
                }
            }
            return false;
        }
    }
}
