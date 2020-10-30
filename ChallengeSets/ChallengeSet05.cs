using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml;
using System.Xml.Schema;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            return ((startNumber / n) + 1) * n;

        }


        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {

                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
                
                    

        }



            public bool IsAscendingOrder(int[] numbers)
            {
                if (numbers == null || numbers.Length == 0)
                {
                    return false;
                }
                for (int i = 1; i < numbers.Length; i++)
                {

                    if (numbers[i - 1] > numbers[i])
                    {
                        return false;
                    }

                }
                return true;

            }

            public int SumElementsThatFollowAnEven(int[] numbers)
            {
                if (numbers == null || numbers.Length == 0)
                {
                    return 0;
                }
                var nums = 0;
                for (int i = 1; i < numbers.Length; i++)
                {

                    if (numbers[i - 1] % 2 == 0)
                    {
                        nums += numbers[i];
                    }
                }
                return nums;
            }
        public string TurnWordsIntoSentence(string[] words)
        {
            string sent = "";// = "" initizlizes empty string
            if( words == null)
            {
                return "";// return empty string
            }
            foreach(var x in words)
            {
                if(x.Trim().Length > 0)
                {
                    sent += x.Trim() +  " "; // elimates excess space with trim and " " puts space between words
                }

            }
                if(sent.Length == 0)
                {
                    return "";
                }


            sent = sent.Substring(0, sent.Length - 1);// eliminates the whitespace in sent
            sent += ".";// adds period to sent for end of sentence
                
            return sent;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var result = new List<double>();
            if( elements == null || elements.Count == 0)
            {
                return new double[0];
            }
           for(int i = 3; i < elements.Count; i += 4)
           {
                result.Add(elements[i]);
           }
            return result.ToArray(); 

        }  


        
               

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i  + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
                
            }
            return false;



        }
        
    }
    
}
