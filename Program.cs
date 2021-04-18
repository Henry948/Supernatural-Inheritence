using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm s = new Storm("wind", false, "Zul'rajas");

      Console.WriteLine(s.Announce());
    }
  }
}