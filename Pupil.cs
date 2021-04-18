using System;

namespace MagicalInheritance
{
  class Pupil
  {
    //Automatic Properties
    public string Title
    { get; private set;}

    // Constructors

    public Pupil(string title)
    {
        Title = title;
    }

    public Storm CastWindStorm()
    {
        return new Storm("wind", false, Title);
    }
  }
}
