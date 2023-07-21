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
  public void FreePastries_CalculateFreePastries_FreePastry()
        {
            Pastry newPastry = new Pastry(14);

            Assert.AreEqual(3, newPastry.FreePastries(14));
        }
        [TestMethod]
        public void PastryTotal_CalculateTotalPastryCount_TotalPastryCount()
        {
            Pastry newPastryItem = new Pastry(14);

            Assert.AreEqual(17, newPastryItem.TotalPastryCount(14, 3));
        }
  }
}