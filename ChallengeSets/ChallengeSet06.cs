using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
          
            bool conditional = false;
            if (words == null)
            {
                return false;
            }
            if (ignoreCase == true)
            {

                foreach (var match in words)
                {
                    if (match == null)
                    {
                        continue;
                    }
                    if (word.ToLower().Contains(match.ToLower()))
                    {
                        
                        if (words.Contains(null))
                        {
                            return false;
                        }
                        else
                        {
                            conditional = false;
                        }
                        return true;
                    }
                }
            }
            if (ignoreCase == false)
            {
                foreach (var match in words)
                {
                    if (match == null)
                    {
                        continue;
                    }
                    if (match == word)
                    {
                        if(match == word)
                        {
                            conditional = true;
                        }
                        else
                        {
                            conditional = false;
                        }
                    }
                }
            }
                  return conditional;
        }
                                                                
                                                         
                                                    
                               
                         
        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var result = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= result; i++)
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
             int MAX = 256;
            int n = str.Length;
            int[] freq = new int[MAX];
            for (int i = 0; i < n; i++)
            {
                freq[str[i]]++;
            }
            for (int i = n - 1; i >= 0; i--)
            {
                char ch = str[i];

                if (freq[ch] == 1)
                {
                    int index = str.IndexOf(ch);
                    return index;

                }

            }

            return -1;
        }
                                                 

        public int MaxConsecutiveCount(int[] numbers)
        {
            int num = 0;
            int tp = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                int cur_count = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                        break;
                    cur_count++;
                }

                if (cur_count > num)
                {
                    num = cur_count;
                    tp = numbers[i];
                }
            }
            return num;
        }

            
            


        


        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nums = new List<double>();
            if ( elements == null || n < 0 )
            {
                return new double[0];
            }
           
            for (int i = 0; i < elements.Count; i++)
            {
                if(elements[i] % n == 0)
                {
                    nums.Add(elements[i]);
                }
               
            }
            return nums.ToArray();
           
        }           
                
            
                    
                        

                

               


    }
}

