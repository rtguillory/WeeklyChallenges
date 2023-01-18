using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(bool val in vals)
            {
                if (!val) { return true; }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
                return false;

            var sum = 0;
            foreach (int n in numbers)
            {
                if(Math.Abs(n) % 2 == 1)
                {
                    sum += n;
                }
            }
            return Math.Abs(sum) % 2 == 1;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = password.Any(c=> char.IsUpper(c));
            bool hasLower = password.Any(c => char.IsLower(c));
            bool hasNumber = password.Any(c => char.IsDigit(c)); ;
            
            return hasUpper && hasLower && hasNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.ToCharArray()[0]; ;
        }

        public char GetLastLetterOfString(string val)
        {
            return val.ToCharArray()[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            return dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int [] oddsBelow100 = new int [50];
            int spot = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                    oddsBelow100[spot++] = i;
            }
            return oddsBelow100;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i<words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
