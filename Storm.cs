using System;

namespace MagicalInheritance
{
    class Storm : Spell
    {

        // Automatic Properties
        // public string Essence
        // { get; private set; }
        // public bool IsStrong
        // { get; private set; }
        // public string Caster
        // { get; private set; }


        // Constructor defining the automatic properties
        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }

        // Public announce method to return a string printing the values stored in the above properties
        public override string Announce()
        {
            if (IsStrong)
            {
                return $"{Caster} cast a strong {Essence} storm!";
            }  else {
                return $"{Caster} cast a weak {Essence} storm!";
            }
        }
    }
}
