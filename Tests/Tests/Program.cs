using System;
using Engine;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = Information;

            Equipment NullEquipment = Create.MakingEquipment(EquipmentType.Null);
            Equipment Belt = Create.MakingEquipment(EquipmentType.Belt);
            Equipment Gloves = Create.MakingEquipment(EquipmentType.Gloves);
            Equipment Helmet = Create.MakingEquipment(EquipmentType.Helmet);
            Equipment Leggings = Create.MakingEquipment(EquipmentType.Leggings);
            Equipment Cuirass = Create.MakingEquipment(EquipmentType.Сuirass);

            Weapon NullWeapon = Create.MakingWeapon(WeaponType.Null);
            Weapon Bow = Create.MakingWeapon(WeaponType.Bow);
            Weapon Dirk = Create.MakingWeapon(WeaponType.Dirk);
            Weapon Fist = Create.MakingWeapon(WeaponType.Fists);
            Weapon Stick = Create.MakingWeapon(WeaponType.Stick);
            Weapon Sword = Create.MakingWeapon(WeaponType.Sword);

            Magic NullMagic = Create.MakingMagic(MagicType.Null);
            Magic MagicArrow = Create.MakingMagic(MagicType.Arrow);
            Magic Fireball = Create.MakingMagic(MagicType.Fireball);
            Magic MagicFist = Create.MakingMagic(MagicType.Fist);
            Magic Lightning = Create.MakingMagic(MagicType.Lightning);
            Magic Rock = Create.MakingMagic(MagicType.Rock);

            Hero Oracl = new Hero("Oracl");
            Oracl.Info += Show;
            Oracl.NewHero();

            Hero Hulk = new Hero("Hulk");
            Hulk.Info += Show;
            Hulk.NewHero();

            Oracl.BuyingEquipment(Belt);
            Oracl.BuyingEquipment(Gloves);
            Oracl.BuyingMagic(MagicArrow);

            Hulk.BuyingWeapons(Sword);
            Hulk.BuyingMagic(Lightning);
            Hulk.BuyingEquipment(Belt);

            Fight(Oracl, Hulk);

            Console.WriteLine(Oracl.CurrentHealth);
            Console.WriteLine(Oracl.CurrentMana);
            Console.WriteLine(Oracl.Balance);
            Console.WriteLine(Hulk.CurrentHealth);
            Console.WriteLine(Hulk.CurrentHealth);
            Console.WriteLine(Hulk.Balance);

            Oracl.RestoreHealth(Oracl.MaxHealth);
            Oracl.RestoreMana(Oracl.MaxMana);
            Hulk.RestoreHealth(Hulk.MaxHealth);
            Hulk.RestoreMana(Hulk.MaxMana);

            Console.WriteLine();
            Console.WriteLine(Oracl.CurrentHealth);
            Console.WriteLine(Oracl.CurrentMana);
            Console.WriteLine(Oracl.Balance);
            Console.WriteLine(Hulk.CurrentHealth);
            Console.WriteLine(Hulk.CurrentHealth);
            Console.WriteLine(Hulk.Balance);
        }
        public static void Show(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Information(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Fight(Hero hero1, Hero hero2)
        {
            do
            {
                hero1.GetInnerDamage(hero2.DealDamage());
                hero2.GetInnerDamage(hero1.DealDamage());
            } while (hero1.IsAlive() && hero2.IsAlive());

            if (hero1.IsAlive())
            {
                Console.WriteLine($"Победил {hero1.Name}");
                hero1.GetMoney(5);
                hero2.RestoreHealth(0 - hero2.CurrentHealth);
            }
            else if (hero2.IsAlive())
            {
                Console.WriteLine($"Победил {hero2.Name}");
                hero2.GetMoney(5);
                hero1.RestoreHealth(0 - hero1.CurrentHealth);
            }
            else
            {
                Console.WriteLine("Оба героя мертвы - ничья!");
            }
        }
    }
}
