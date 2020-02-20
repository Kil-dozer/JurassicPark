using System;
using System.Collections.Generic;
using System.Linq;
// THIS IS ENCAPSULATION

namespace JurassicPark
{
  public class DinoTracker
  {
    public List<Dinosaur> Dinos { get; set; } = new List<Dinosaur>();

    public void AddADino()
    {
      Console.WriteLine("What dinosaur would you like to add?");
      var kind = Console.ReadLine();
      Console.WriteLine("How many pounds does it weight?");
      var pound = int.Parse(Console.ReadLine());
      Console.WriteLine($"Is {kind} a herbivore or a carnivore?");
      var food = Console.ReadLine().ToLower();
      var diet = "";
      if (food == "carnivore")
      {
        diet = "carnivore";
      }
      else if (food == "herbivore")
      {
        diet = "herbivore";
      }
      Console.WriteLine("What enclosure number do you want to send it to?");
      var home = int.Parse(Console.ReadLine());
      var creationTime = DateTime.Now;
      var dino = new Dinosaur
      {
        WhatItIs = kind,
        WhatItWeights = pound,
        WhatItEats = diet,
        WhenCollected = creationTime,
        WhereItLives = home

      };
      Dinos.Add(dino);

    }
    public void RemoveADino()
    {
      Console.WriteLine("What dinosaur do you want to remove");
      var kind = Console.ReadLine();
      var dino = new Dinosaur
      {
        WhatItIs = kind,
      };
      var dinoToRemove = Dinos.Where(dino => dino.WhatItIs == kind).ToList();

      if (dinoToRemove.Count() > 1)
      {
        Console.WriteLine($"We found multiple {kind}, which do you want to remove?");
        for (int i = 0; i < dinoToRemove.Count; i++)
        {
          var goneDino = dinoToRemove[i];
          Console.WriteLine($"{i + 1}: {goneDino.WhenCollected} at ");

        }
        var index = int.Parse(Console.ReadLine());
        Dinos.Remove(dinoToRemove[index - 1]);
      }
      else
      {

        Dinos.Remove(dinoToRemove.First());
      }
      Console.WriteLine($"The following dino was remove: {kind}");

    }
    public void Relocate()
    {
      // needs finish
      Console.WriteLine("Which dinosaur would you like to relocate?");
      var kind = Console.ReadLine();
      Console.WriteLine($"What enclosure will be {kind}'s new home?");
      var home = int.Parse(Console.ReadLine());
      var dino = new Dinosaur
      {
        WhatItIs = kind,
        WhereItLives = home

      };
      var dinoRelocated = Dinos.Where(dino => dino.WhereItLives == home);


    }
    public void Heavies()
    {
      for (int i = 0; i < Dinos.Count; i++)
      {
        var heavyBoys = Dinos.OrderBy(dino => dino.WhatItWeights);


        while (i < 2)
        {
          Console.WriteLine(heavyBoys);
        }
      }
    }
    public void Menu()
    {
      var meatEaters = Dinos.Select(dino => dino.WhatItEats == "carnivore");
      var plantEaters = Dinos.Select(dino => dino.WhatItEats == "herbivore");
      Console.WriteLine($"{meatEaters}");

    }
  }
}


