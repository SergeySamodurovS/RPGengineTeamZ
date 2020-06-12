using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public delegate void Message(string msg);
    public class Hero
    {
        public event Message Info;
        public string Name { private set; get; } //Имя
        public int Level { private set; get; } //Уровень
        public int Experience { private set; get; } //Опыт
        public int Damage { private set; get; } //Урон
        public int Balance { private set; get; } //Монеты
        public Weapon Weapon { private set; get; } //Оружие
        public int Health { private set; get; } //Здоровье
        public int Mana { private set; get; } //Мана
        public Magic Magic { private set; get; } //Магия
        public bool IsAlive { set; get; } //Жив ещё
        public List<Equipment> equipment; //список экипировки

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            Experience = 0;
            Damage = 10;
            Health = 50;
            Mana = 50;
            Balance = 20;
            IsAlive = true;
            equipment = new List<Equipment>();
            Info($"Герой {this.Name} пришёл в этот мир {DateTime.Now}. У Вас есть {this.Health} единиц здоровья, {this.Mana} единиц маны, Вы наносите {this.Damage} единиц урона, Вам выдано {this.Balance} золотых.");
        }
        
        public void BuyingEquipment(Equipment purchasedEquipment) 
        {
            if ((Balance >= purchasedEquipment.cost) && !equipment.Contains(purchasedEquipment))
            {
                equipment.Add(purchasedEquipment);
                Balance -= purchasedEquipment.cost;
                Info?.Invoke($"Вы купили {purchasedEquipment.type} и потратили {purchasedEquipment.cost}");
            }
            else if(Balance < purchasedEquipment.cost)
            {
                Info?.Invoke("Средств не достаточно");
            }else if (equipment.Contains(purchasedEquipment))
            {
                Info?.Invoke($"У вас уже есть {purchasedEquipment.type}");
            }
        }
        public void BuyingWeapons(Weapon purchasedWeapon)
        {
            if (Balance >= purchasedWeapon.cost)
            {
                Weapon = purchasedWeapon;
                Balance -= purchasedWeapon.cost;
                Info?.Invoke($"Покупка совершена. Теперь Ваше оружие - {Weapon.type}, у Вас осталось {Balance} золотых.");
            }
            else
            {
                Info?.Invoke("Средств не достаточно");
            }
        }
        public void BuyingMagic(Magic purchasedMagic)
        {
            if (Balance >= purchasedMagic.cost)
            {
                Magic = purchasedMagic;
                Balance -= purchasedMagic.cost;
                Info?.Invoke($"Покупка совершена. Теперь Ваша магия - {Magic.magicType}, у Вас осталось {Balance} золотых.");
            }
            else
            {
                Info?.Invoke("Средств не достаточно");
            }
        }
        public void AliveOrDead(int damage)
        {
            if ((Health - damage) <= 0)
            {
                IsAlive = false;
                Info?.Invoke("Вы мертвы");
            }
            else 
            {
                Info?.Invoke("Вы ещё живы, продолжайте");
            }
        }
    }
}
