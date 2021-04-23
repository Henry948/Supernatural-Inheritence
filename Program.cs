using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
        Pupil p = new Pupil("Mezil-kree");
        Storm windstorm = p.CastWindStorm();
        Console.WriteLine(windstorm.Announce());

        Mage m = new Mage("Gul'dan");
        Storm rainStorm = m.CastRainStorm();
        Console.WriteLine(rainStorm.Announce());

        Archmage a = new Archmage("Nielas Aran");
        Storm archmageRainStorm = a.CastRainStorm();
        Storm archmageLightningStorm = a.CastLightningStorm();
        Console.WriteLine(archmageLightningStorm.Announce());
        Console.WriteLine(archmageRainStorm.Announce());
    }
  }
}