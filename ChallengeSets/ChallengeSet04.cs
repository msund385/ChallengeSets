using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evens = 0; int odd = 0;int sum = 0;
            foreach(var v in numbers)
            {
                if(v % 2 == 0)
                {
                    evens += v;
                }
                if(v % 2 != 0)
                {
                    odd += v;
                }
            }
            return sum + evens - odd;


        }
              
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] words = { str1, str2, str3, str4 };
            int shortWord = words.Min(w => w.Length);
            return shortWord;
        }


        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] all = new int[] { number1, number2, number3, number4 };

            return all.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
             biz.Name = "TrueCoders";
        }




        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsStringANumber(string input)
        {
            float num;
            return float.TryParse(input, out num);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var count = 0;
            foreach (var n in objs)
            {
                if (n == null)
                {
                    count++;
                }
            }
            if (count > objs.Length / 2)
            {
                return true;
            }else
            {
                return false;
            }

                
        }
        public double AverageEvens(int[] numbers)
        {
            double evenSum = 0; 
           
            double evenCount = 0;

            if ( numbers == null)
            {
                return 0;
            }
            foreach (var v in numbers)
            {
                if (v % 2 == 0)
                {
                   evenSum +=  v;
                    evenCount++;
                }
                
                

            }
             if(evenCount > 0)
             {
                return evenSum / evenCount;
             }
             else
             {
                return 0;
             }
         


        }

        public int Factorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            return number == 1 ? 1 : number * Factorial(number - 1);
        }



    }

}







































