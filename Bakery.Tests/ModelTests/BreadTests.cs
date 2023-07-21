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
  }
}