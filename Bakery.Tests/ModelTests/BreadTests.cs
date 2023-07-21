using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void FreeLoaf_CalculateFreeLoaf_FreeBread() 
    {
      Bread newBread = new Bread(14);

      Assert.AreEqual(7, newBread.FreeBread(14));
    }
     [TestMethod]
    public void BreadTotal_CalculateTotalBreadOwed_TotalBreadCount()
    {
    Bread newBreadItem = new Bread(14);

    Assert.AreEqual(21, newBreadItem.TotalBreadCount(14,7));
    }
    [TestMethod]
    public void BreadCost_CalculateTotalCostOwed_CustomerCost()
    {
      Bread newBread = new Bread(14);

      Assert.AreEqual(70, newBread.CustomerCost(14));
    }

  }
}