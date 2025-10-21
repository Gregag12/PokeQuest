//DONE: Phase 1 Enums
//DONE: Define PokemonType enum (Fire, Eater, Grass, etc)
//DONE: Define MoveCategory enum (Physical, Special, Status)
//DONE: Define BattleResult enum (Win, Loss, Draw)
//DONE: Add WeatherCondition enum
//DONE: Add StatusEffect enum -- Changed to StatusCondition
//DONE: Add Region enum
//DONE: Add VolatileStatus enum
using System;

namespace Pokemon
{
    public enum PokemonType //The type of pokemon  
    {
        Bug,
        Dark,
        Dragon,
        Electric,
        Fairy,
        Fighting,
        Fire,
        Flying,
        Ghost,
        Grass,
        Ground,
        Ice,
        Normal,
        Poison,
        Psychic,
        Rock,
        Steel,
        Stellar,
        Water
    }
    public enum MoveCategory //Defines the type of move
    {
        Physical,
        Special,
        Status
    }
    public enum BattleResult //Defines battle outcomes
    {
        Win,
        Lose,
        Draw
    }
    public enum WeatherCondition //Certain pokemon moves are effected by weather condition
    {
        None, // No special weather  condition (default)
        HarshSunlight,
        Rain,
        Hail,
        Snow,
        Sandstorm,
        Fog,
        ExtremeSun,
        HeavyRain,
        StrongWinds,
        ShadowyAura
    }
    public enum Regions //The region the Pokemon/players are from
    {
        Kanto,
        Johto,
        Hoenn,
        Sinnoh,
        Unova,
        Kalos,
        Alola,
        Galar,
        Paldea
    }
    public enum StatusCondition //The permanent status given to a pokemon after certain moves are performed. A pokemon must be healed/fainted to remove the effect
    {
        None, // No special status condition (default)
        Asleep,
        Burned,
        Frozen,
        Paralyzed,
        Poisened
    }

    public enum VolatileStatus //Secondary status effect that is temporary (if a Pokemon leaves active play, the status is removed)
    {
        None, // Default status
        Confused,
        Flinched,
        Infatuated,
        LeechSeeded,
        Taunt,
        Trapped
    }

}