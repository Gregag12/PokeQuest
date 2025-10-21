//TODO: Phase 1
//TODO: Create a static class or dictionary that holds all available Pokemon templates
//TODO: Add method GetPokemonByName (string name) that returns a deep copy
//TODO: Populate witha few starter Pokemon (Depending on the region the player chooses to start)

using System;
using System.Runtime;

namespace Pokemon
{
    public class NationalDex : Pokedex 
    {
        public Dictionary<int, Pokemon> ById = new Dictionary<int, Pokemon>();
        public Dictionary<string, Pokemon> ByName = new Dictionary<string, Pokemon>();

        public override void AddPokemon(Pokemon p)
        {
            AllPokemon.Add(p);
            ById[p.NationalDexNumber] = p;
            ByName[p.Name] = p;
        }

        public override Pokemon GetPokemonByName(string name)
        {
            if (ByName.ContainsKey(name))
            {
                return ByName[name];
            }
            else
            {
                return null;
            }
        }

         public override Pokemon GetPokemonById(int id)
        {
            if (ById.ContainsKey(id))
            {
                return ById[id];
            }
            else
            {
                return null;
            }
        }
    }
}