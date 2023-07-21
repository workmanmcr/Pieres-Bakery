using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryPromo_CalculateNumberOfFreePastries_FreePastry()
    {
    Pastry newPastryItem = new Pastry(11);

    Assert.AreEqual(3, newPastryItem.FreePastry(11));
    }
  }
}