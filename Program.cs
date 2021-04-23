using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {

        Storm[] storms = new Storm[10];
        int stormsIndex = 0;

        Pupil p = new Pupil("Mezil-kree");

        storms[stormsIndex] = p.CastWindStorm();
        stormsIndex++;

        Mage m = new Mage("Gul'dan");

        storms[stormsIndex] = m.CastRainStorm();
        stormsIndex++;

        Archmage a = new Archmage("Nielas Aran");

        storms[stormsIndex] = a.CastRainStorm();
        stormsIndex++;

        storms[stormsIndex] = a.CastLightningStorm();
        stormsIndex++;
 
        for (int i = 0; i < stormsIndex; i++)
        {
          Console.WriteLine(storms[i].Announce());
        }
    }
  }
}