using System;

namespace MagicalInheritance
{
  class Pupil
  {
    //Automatic Properties
    public string Title
    { get; private set;}
    public string Origin
    {get; private set;}

    // Constructors

    public Pupil(string title)
    {
        Title = title;
    }

    public Pupil(string title, string origin) : this(title)
    {
      Origin = origin;
    }

    public Storm CastWindStorm()
    {
        return new Storm("wind", false, Title);
    }

    
  }
}
