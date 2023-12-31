using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCount { get; set; }
    public Bread(int breadCount)
    {
      BreadCount = breadCount;
    }
    public int FreeBread(int breadCount)
    {
      int breadPromoRate = 2;
      int breadCountFree = breadCount / breadPromoRate;
      return breadCountFree;
    }
    public int TotalBreadCount(int breadCount, int breadCountFree)
    {
      int totalLoaves = breadCount + breadCountFree;
      return totalLoaves;
    }
    public int CustomerCost(int breadCount)
    {
      int breadPrice = 5;
      int breadCountCost = breadCount * breadPrice;
      return breadCountCost;
    }
  }
}