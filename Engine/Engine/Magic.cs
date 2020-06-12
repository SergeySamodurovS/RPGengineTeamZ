//Нужно создать несколько видов магии, которые стоят разное количество денег и наносят разное количество урона.
//UPD: магия расходует ману, поэтому должен быть параметр, который это учитывает.
//Виды магии: боевая, магия поддержки (лечение, увеличение показателей персонажа на время).
//Значения минимальных требований для изучения: ловкость, сила, выносливость, интеллект, уровень.

using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public enum MagicType { Null, Arrow, Lightning, Fist, Fireball, Rock } //Виды магии
    public class Magic
    {
        public string magicName;
        public int damage;
        public int cost;
        public int manaCost;
        public MagicType magicType;

        public Magic(string magicName, int damage, int cost, int manaCost, MagicType magicType)
        {   
            this.magicName = magicName;
            this.damage = damage;
            this.cost = cost;
            this.manaCost = manaCost;
            this.magicType = magicType;
        }
    }
}