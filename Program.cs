using System;
using System.Collections.Generic;
using System.Linq;
namespace JurassicPark
{
  class Program
  {
    static void Main(string[] args)
    {
      var isRunning = true;
      var tracker = new DinoTracker();

      Console.WriteLine("Welcome to Jurassic Park!");
      while (isRunning == true)
      {
        Console.WriteLine("What would you like to do");
        Console.WriteLine("(VIEW) all dinosaurs");
        Console.WriteLine("(ADD) a dinosaur to the park");
        Console.WriteLine("(REMOVE) a dinosaur from the park");
        Console.WriteLine("(RELOCATE) a dinosaur to a new enclosure");
        Console.WriteLine("(WEIGHT) show the three heaviest dinosaurs in the park");
        Console.WriteLine("(MENU) view a summary of the parks dietary needs");
        Console.WriteLine("(QUIT) quit the program");
        var input = Console.ReadLine().ToLower();
        if (input == "view")
        {
          foreach (var s in tracker.Dinos)
          {
            Console.WriteLine($"{s.WhatItIs} at {s.WhereItLives} at {s.WhenCollected}");
          }
        }
        // add
        else if (input == "add")
        {
          tracker.AddADino();
        }
        else if (input == "remove")
        {
          tracker.RemoveADino();
        }

        else if (input == "relocate")
        {
          tracker.Relocate();
        }
        else if (input == "weight")
        {
          tracker.Heavies();
        }
        else if (input == "menu")
        {

        }
        else if (input == "quit")
        {
          isRunning = false;
          Console.WriteLine("Goodbye");
          Console.ReadLine();
        }
      }

    }
  }
}
