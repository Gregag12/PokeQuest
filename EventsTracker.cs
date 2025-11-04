//TODO: Create the tracker
    //DONE: Create a new file called EventsTracker
    //DONE: Define the EventsTracker class
    //TODO: Initialize a dictionary to store Pokemon data
    
using System;

namespace Pokemon.Events
{
    public class EventsTracker
    {
        public Dictionary<string, Dictionary<string, PokemonEvent>> tracker;
        public EventsTracker()
        {
            tracker = new Dictionary<string, Dictionary<string, PokemonEvent>>();
        }
    }
    public class PokemonEvent
    {
        public DateTime DateCaught { get; set; }
        public List<string> MovesUsed { get; set; } = new List<string>();
        public int TimesBattled { get; set; } = 0;
        
        // Constructor with parameters
        public PokemonEvent(DateTime dateTime, List<string> movesUsed, int timesBattled)
        {
            DateCaught = dateTime;
            MovesUsed = movesUsed;
            TimesBattled = timesBattled;
        }

        // Default constructor
        public PokemonEvent()
        {
            DateCaught = DateTime.Now;
            MovesUsed = new List<string>();
            TimesBattled = 0;
        }

        public void AddPokemon(string name)
        {
            if (!tracker.ContainsKey(name))
            {
                tracker[name] = new PokemonEvent();
                Console.WriteLine($"{name} added to tracker.");
            }
            else
            {
                Console.WriteLine($"{name} is already in the tracker.");
            }
        }
    }
}