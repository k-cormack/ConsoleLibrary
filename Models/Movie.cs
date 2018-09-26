using System;
using System.Collections.Generic;

namespace ConsoleTheater.Models
{
  public class Movie
  {
    public string Title { get; set; }

    public Movie(string title)
    {
      Title = title;
    }
  }
}