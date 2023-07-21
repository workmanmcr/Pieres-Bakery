using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Bakery.Models.Bread testBread = new Bakery.Models.Bread();
      Console.WriteLine(testBread.GetType());
    }
  }
}