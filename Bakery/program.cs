using Bakery;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
// using Bakery.Logic;

namespace Bakery
{
   public class Program
    {
        public static void Main()
        {
            int breadCount = 10;
            Bread bakeryBread = new Bread(breadCount);
            int breadCountFree = bakeryBread.FreeBread(breadCount);
            int totalLoaves = bakeryBread.TotalBreadCount(breadCount, breadCountFree);
            int breadCountCost = bakeryBread.CustomerCost(breadCount);

            Console.WriteLine($"Bread Count: {breadCount}");
            Console.WriteLine($"Free Bread Count: {breadCountFree}");
            Console.WriteLine($"Total Loaves: {totalLoaves}");
            Console.WriteLine($"Customer Cost: ${breadCountCost}");

             int pastryCount = 10;
            Pastry bakeryPastry = new Pastry(pastryCount);
            int pastryCountFree = bakeryPastry.FreePastries(pastryCount);
            int totalPastries = bakeryPastry.TotalPastryCount(pastryCount, pastryCountFree);
            int pastryCountCost = bakeryPastry.CustomerCost(pastryCount);

            Console.WriteLine($"Pastry Count: {pastryCount}");
            Console.WriteLine($"Free Pastries: {pastryCountFree}");
            Console.WriteLine($"Total Pastries: {totalPastries}");
            Console.WriteLine($"Customer Cost: ${pastryCountCost}");
        }
    }
}