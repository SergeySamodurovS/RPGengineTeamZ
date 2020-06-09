using System;

namespace Engine
{
    public class Hero
    {
        public string Name { private set; get; } //Имя
        public int Level { private set; get; } //Уровень
        public int Experience { private set; get; } //Опыт
        public int Damage { private set; get; } //Урон
        public int Balance { private set; get; } //Монеты
        public Equipment Equipment { private set; get; } //Экипировка
        public Weapon Weapon { private set; get; } //Оружие
        public int Health { private set; get; } //Здоровье
        public int Mana { private set; get; } //Мана
        public Magic Magic { private set; get; } //Магия

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
