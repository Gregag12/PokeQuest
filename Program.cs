using System;

namespace Pokemon
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            tracker["Charmander"] = new PokemonEvent(DateTime.Now, new List<string> { "Scratch", "Ember" }, 5);
            Console.WriteLine("Pokemon Events Tracker Initialized.");

            
        }
    }
}