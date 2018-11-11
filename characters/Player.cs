using System.Collections.Generic;

namespace eskayrim
{
    public class Player
    {
        public string name;
        public int health;
        public int stamina;
        public int magicka;
        public int dmg;
        public List<Item> inventory = new List<Item>();
        public Room currentLocation;
    }
}