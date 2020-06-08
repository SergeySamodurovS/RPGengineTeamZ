using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Equipment
    {
        public enum EquipmentType { Null, Helmet, Сuirass, Leggings, Gloves }
        public string name;
        public int armor;
        public int cost;
        public EquipmentType type;
        public Equipment(string name, int armor, int cost, EquipmentType type)
        {
            this.name = name;
            this.armor = armor;
            this.cost = cost;
            this.type = type;
        }
    }
}
