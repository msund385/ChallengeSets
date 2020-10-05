using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Markup;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
        }
           public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
           {
              if( numbers == null || numbers.Count() == 0)
              {
                return false;
              }
               var sum = numbers.Sum();
               return (sum % 2 != 0);
           }                           
                                                          
                                                                                            
                             
                                                                                                                                                                                    
            public bool PasswordContainsUpperLowerAndNumber(string password)
            {
             bool up = false;
             bool lo = false;
             bool n = false;
            
            foreach( var t in password)
            {
              if(char.IsUpper(t))
              {
                 up = true; 
              }
              if(char.IsLower(t))
              {
                    lo = true;
              }
              if(char.IsNumber(t))
              {
                    n = true;
              }
                

            }
             if (up == true && lo == true && n == true)
             {
                return true;
                
             }
            else
            {
                return false;
            }
          }  



        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            return val[val.Length - 1];
        }
         public decimal Divide(decimal dividend, decimal divisor)
         {
           if(divisor == 0)
            {
                return 0;
            }
           else
            {
                return dividend / divisor;
            }
         }
           public int LastMinusFirst(int[] nums)
           {
            foreach (var v in nums)
            {
                return nums[nums.Count() - 1] - nums[0];
            }
            return 0;
           }
           public int[] GetOddsBelow100()
           {
            var odds = new List<int>();
            for (int n = 0; n < 100; n++)
            {
                if (n % 2 != 0)
                {

                    odds.Add(n);
                }
            }
            return odds.ToArray();


        }


        public void ChangeAllElementsToUppercase(string[] words)
            {
             for (int i = 0; i < words.Length; i++)
             {
                words[i] = words[i].ToUpper();
             }
            }
           
             


              
            






    }
}


