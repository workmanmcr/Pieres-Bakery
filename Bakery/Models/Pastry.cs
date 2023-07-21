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
        pastryCount = pastryCount;
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
  }
}