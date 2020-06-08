using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon
    {
        public enum WeaponType { Fists, Sword, Stick, Bow, Dirk }
        public string name;
        public int damage;
        public int cost;
        public WeaponType type;
        public Weapon(string name, int damage, int cost, WeaponType type)
        {
            this.name = name;
            this.damage = damage;
            this.cost = cost;
            this.type = type;
        }
    }
}
