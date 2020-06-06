using System;

namespace Engine
{
    public class Hero
    {
        public string Name { private set; get; }
        public int Level { private set; get; }
        public int Experience { private set; get; }
        public int Damage { private set; get; }
        public int Balance { private set; get; }
        public Equipment Equipment { private set; get; }
        public Weapon Weapon { private set; get; }
        public int Health { private set; get; }
        public int Mana { private set; get; }
        public Magic Magic { private set; get; }

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            Experience = 0;
            Damage = 10;
            Health = 100;
            Mana = 0;
            Balance = 10;
        }
    }
}
