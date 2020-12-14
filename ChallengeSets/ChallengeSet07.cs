using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            int profit = 0;
          
                if(businesses != null)
                {
                    foreach (var x in businesses)
                    {
                     if (x.TotalRevenue - x.TotalExpenses < 0)
                     {
                        profit++;
                     }
                    
                    }
                }
                  return profit;
        }
                

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            var list = businesses.Where(x => x.TotalRevenue - x.TotalExpenses > 0).Select(x => x.Name);
            return String.Join(",", list);
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            if (business.ParentCompany == null)
                return business.Name;

            business.Name = GetNameOfHighestParentCompany(business.ParentCompany);
            return business.Name;
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            string win = "100100100010010010001001001111000000000111000000000111100010001001010100";
            string test = "";
            char[] check;
            for (int x = 0; x < 8; x++)
            {
                check = win.Substring(x * 9, 9).ToCharArray();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (finalBoard[i, j] == 'X') check[i * 3 + j] = '0';
                    }
                }
                test = new string(check);
                if (test == "000000000") return TicTacToeResult.X;
            }

            for (int x = 0; x < 8; x++)
            {
                check = win.Substring(x * 9, 9).ToCharArray();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (finalBoard[i, j] == 'O') check[i * 3 + j] = '0';
                    }
                }
                test = new string(check);
                if (test == "000000000") return TicTacToeResult.O;
            }
            return TicTacToeResult.Draw;
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers.Length == 0 || numbers == null) return false;

            int ticker = 0;

            foreach(int[] nums in numbers)
            {
                if(nums.Contains(targetNumber))
                {
                    ticker++;
                }

                
            }
            if (ticker == numbers.Length) return true;
            return false;
        }
    }
}
