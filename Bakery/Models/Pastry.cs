using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Bakery.Models
{
  public class Pastry
  {
        public int PastryCount { get; set; }

    public Pastry(int pastryCount)
    {
        PastryCount = pastryCount;
    }
     public int FreePastries(int pastryCount)
        {
            int pastryPromoRate = 4;
            int pastryCountFree = pastryCount / pastryPromoRate;
            return pastryCountFree;
        }
          public int TotalPastryCount(int pastryCount, int pastryCountFree)
        {
            int totalPastries = pastryCount + pastryCountFree;
            return totalPastries;
        }
          public int CustomerCost(int pastryCount)
        {
            int pastryPrice = 2;
            int pastryCountCost = pastryCount * pastryPrice;
            return pastryCountCost;
        }
  }
}