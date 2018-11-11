using System.Collections.Generic;

namespace eskayrim
{
    public class Character
    {
        public string name;
        public string race;
        public int health;
        public int healthRegen;
        public int stamina;
        public int staminaRegen;
        public int magicka;
        public int magickaRegen;
        public List<Item> inventory = new List<Item>();
        public List<IPower> powers = new List<IPower>();
    }
}