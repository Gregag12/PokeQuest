using System;
using System.Runtime;

namespace Pokemon
{
    public abstract class Pokedex
    {
        protected List<Pokemon> AllPokemon { get; set; } = new List<Pokemon>();

        public abstract void AddPokemon(Pokemon p);
        public abstract Pokemon GetPokemonByName(string name);
        public abstract Pokemon GetPokemonById(int id);
        public virtual void PrintAllPokemon()
        {
            foreach (var p in AllPokemon)
            {
                Console.WriteLine($"{p.NationalDexNumber}: {p.Name}");
            }
        }
    }
}