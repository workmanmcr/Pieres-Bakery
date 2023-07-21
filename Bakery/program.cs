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
        }
    }
}