using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();




        }



        public int GetLengthOfShortestString(string str1, string str2)
        {

            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }




        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            return numbers.Sum();
        }
        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int evens = 0;
            foreach(var x in numbers)
            {
                if (x % 2 == 0)
                {
                    evens += x;
                }
            }
            return evens;

        }




        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }

            foreach (var x in numbers)
            {
                numbers.Sum();
                if (numbers.Sum() % 2 == 0)
                {
                    return false;
                }
                
            }
            return true;


        }
        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            return number / 2;
           
        }

           













        




        

        
    }
      
}
       

















