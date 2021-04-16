using System;

namespace MagicalInheritance
{
    class Storm
    {

        // Automatic Properties
        public string Essence
        { get; private set; }
        public bool IsStrong
        { get; private set; }
        public string Caster
        { get; private set; }


        // Constructor defining the automatic properties
        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }
    }
}
