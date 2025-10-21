//TODO: Phase 1 Pokemon
//DONE: Create base Pokemon class with (Properties: Name, Level, Type(s), Stats, Moves, CaptureRate)
//TODO: Create Methods: TakeDamage(), AttackTarget(), GainExperience(), LevelUp
//TODO: Impliment Contructor to initialize stats
//TODO: Add method for status effects (burn, poison, etc)
using System;

namespace Pokemon
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int HP { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public List<PokemonType> Types { get; set; } = new List<PokemonType>();
        public DateTime EncounteredDate { get; set; }
        public DateTime CapturedDate { get; set; }
        public List<Move> Moves { get; set; } = new List<Move>();
        public int CaptureRate { get; set; }


        public void TakeDamage(int damage)
        {
            CurrentHP -= damage;
            if (CurrentHP < 0) CurrentHP = 0;
                if (CurrentHP == 0)
                {
                Console.WriteLine($"{Name} has fainted!");
                }
        }

        public void AttackTarget()
        {

        }

        public void GainExperience()
        {

        }

        public void LevelUp()
        {
            
        } 
    }
}