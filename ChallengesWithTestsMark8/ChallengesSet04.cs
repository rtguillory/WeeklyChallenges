using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                    total+= numbers[i];
                else
                    total-= numbers[i];
            }

            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //int min1 = Math.Min(str1.Length,str2.Length);
            //int min2 =Math.Min(str4.Length,str3.Length);
            
            //return Math.Min(min1,min2);
            return Math.Min(Math.Min(str1.Length, str2.Length), Math.Min(str4.Length, str3.Length));
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            double num;
            return double.TryParse(input, out num);
                
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int numNull = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                    numNull++;
            }
            return numNull > objs.Length/2;
        }

        public double AverageEvens(int[] numbers)
        {
            if(null == numbers)
                return 0;
            double sum = 0;
            int numEvens = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    numEvens++;
                    sum += number;
                }
            }

            if (numEvens == 0)
                return 0;

            return sum / numEvens;
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number ==0 || number == 1)
            {
                return 1;
            }

            int fact = 1;
            for(int i = number; i > 1; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
