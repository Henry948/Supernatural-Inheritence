using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm s = new Storm("wind", false, "Zul'rajas");

      Console.WriteLine(s.Announce());

      Pupil p = new Pupil("Mezil-kree");
      Storm windStorm = p.CastWindStorm();
      Console.WriteLine(windStorm.Announce());

      Mage m = new Mage("Gul’dan");
      Storm rainStorm = m.CastRainStorm();
      Console.WriteLine(rainStorm.Announce());
    }
  }
}