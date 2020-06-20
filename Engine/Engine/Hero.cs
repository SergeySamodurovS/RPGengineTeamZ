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
        public int Balance { private set; get; } //Монеты, деньги
        public Weapon Weapon { private set; get; } //Оружие
        public int MaxHealth { private set; get; } //Максимальный уровень здоровья
        public int CurrentHealth { private set; get; } //Текущий уровень здоровья
        public int MaxMana { private set; get; } //Максимальный уровень маны
        public int CurrentMana { private set; get; } //Текущий уровень маны
        public Magic Magic { private set; get; } //Магия
        public List<Equipment> equipment; //Список экипировки

        public Hero(string name)
        {
            Name = name;
        }
        public void NewHero()
        {
            Level = 1;
            Experience = 0;
            Damage = 10;
            MaxHealth = 50;
            CurrentHealth = 50;
            MaxMana = 50;
            CurrentMana = 50;
            Balance = 20;
            equipment = new List<Equipment>();
            equipment.Add(Create.MakingEquipment(EquipmentType.Null));
            Magic = Create.MakingMagic(MagicType.Null);
            Weapon = Create.MakingWeapon(WeaponType.Null);
            Info($"Герой {Name} пришёл в этот мир {DateTime.Now}. У Вас есть {CurrentHealth} единиц здоровья, {CurrentMana} единиц маны, Вы наносите {Damage} единиц урона, Вам выдано {Balance} золотых.");
        }
        public void BuyingEquipment(Equipment purchasedEquipment) 
        {
            if ((Balance >= purchasedEquipment.cost) && !equipment.Contains(purchasedEquipment))
            {
                equipment.Add(purchasedEquipment);
                Balance -= purchasedEquipment.cost;
                Info?.Invoke($"Вы купили {purchasedEquipment.type} и потратили {purchasedEquipment.cost}, у Вас осталось {Balance} золотых.");
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
                Info?.Invoke($"Покупка совершена. Теперь Ваше оружие - {Weapon.type}, Вы потратили {Weapon.cost}, у Вас осталось {Balance} золотых.");
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
                Info?.Invoke($"Покупка совершена. Теперь Ваша магия - {Magic.magicType}, Вы потратили {Magic.cost}, у Вас осталось {Balance} золотых.");
            }
            else
            {
                Info?.Invoke("Средств не достаточно");
            }
        }
        public int DealDamage()
        {
            int dmg = 0;
            if (CurrentMana >= Magic.manaCost)
            {
                dmg = Damage + Weapon.damage + Magic.damage;
                CurrentMana -= Magic.manaCost;
                Info?.Invoke($"Герой {Name} наносит {dmg} урона.");
            }
            else
            {
                dmg = Damage + Weapon.damage;
            }
            return dmg;
        }
        public int GetInnerDamage(int dmg)
        {
            int summaryArmor = 0;
            foreach (var item in equipment)
            {
                summaryArmor += item.armor;
            }
            if ((dmg - summaryArmor) > 0)
            {
                CurrentHealth -= dmg - summaryArmor;
                Info?.Invoke($"Герой {Name} блокирует {summaryArmor} урона, осталось {CurrentHealth} единиц здоровья.");
            }
            else
            {
                Info?.Invoke($"Герой {Name} блокирует {summaryArmor} урона, осталось {CurrentHealth} единиц здоровья.");
            }
            return CurrentHealth;
        }
        public bool IsAlive()
        {
            if (CurrentHealth <= 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        public int GetMoney(int money)
        {
            Balance += money;
            return Balance;
        }
        public int RestoreHealth(int health)
        {
            CurrentHealth += health;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            return CurrentHealth;
        }
        public int RestoreMana(int mana)
        {
            CurrentMana += mana;
            if (CurrentMana > MaxMana)
            {
                CurrentMana = MaxMana;
            }
            return CurrentMana;
        }
    }
}
