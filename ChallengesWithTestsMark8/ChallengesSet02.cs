using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return IsNumberEven(vals.Length);
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return (Math.Abs(num)) % 2 == 1;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null)
                return 0;

            var min = Double.MaxValue;
            var max = Double.MinValue;
            foreach (var number in numbers)
            {
                min = Math.Min(min, number);
                max = Math.Max(max, number);
            }
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length,str2.Length);
        }

        public int Sum(int[] numbers)
        {
            if(numbers==null)
                return 0;

            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;

            var sum = 0;
            foreach (var number in numbers)
            {
                if(IsNumberEven(number))
                    sum += number;
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;

            var sum = 0;
            foreach (var number in numbers)
            {
                 sum += number;
            }

            return IsNumberOdd(sum);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number <= 0)
                return 0;
            return (long)(number / 2.0);
            /*var count = 0;
            for(int i = 1; i < number; i++)
            {
                if (IsNumberOdd(i)) 
                { count++; }
            }
            return count;*/
        }
    }
}
