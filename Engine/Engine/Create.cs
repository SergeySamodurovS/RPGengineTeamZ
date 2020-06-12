using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class Create
    {
        public static Equipment MakingEquipment(EquipmentType type)
        {
            switch (type)
            {
                case EquipmentType.Helmet:
                    Equipment equipmentHelmet = new Equipment("Helmet", 10, 15, EquipmentType.Helmet);      //Шлем
                    return equipmentHelmet;
                case EquipmentType.Сuirass:
                    Equipment equipmentСuirass = new Equipment("Сuirass", 15, 20, EquipmentType.Сuirass);   //Кираса
                    return equipmentСuirass;
                case EquipmentType.Belt:
                    Equipment equipmentBelt = new Equipment("Belt", 5, 7, EquipmentType.Belt);              //Пояс
                    return equipmentBelt;
                case EquipmentType.Leggings:
                    Equipment equipmentLeggings = new Equipment("Leggings", 8, 10, EquipmentType.Leggings); //Поножи
                    return equipmentLeggings;
                case EquipmentType.Gloves:
                    Equipment equipmentGloves = new Equipment("Gloves", 8, 10, EquipmentType.Gloves);       //Перчатки
                    return equipmentGloves;
                case EquipmentType.Null:
                    Equipment equipmentNull = new Equipment("Null", 0, 0, EquipmentType.Null);
                    return equipmentNull;
                default:
                    equipmentNull = new Equipment("Null", 0, 0, EquipmentType.Null);
                    return equipmentNull;
            }
        }
        public static Weapon MakingWeapon(WeaponType type)
        {
            switch (type)
            {
                case WeaponType.Bow:
                    Weapon weaponBow = new Weapon("Bow", 10, 10, WeaponType.Bow);       //лук
                    return weaponBow;
                case WeaponType.Dirk:
                    Weapon weaponDirk = new Weapon("Dirk", 5, 5, WeaponType.Dirk);      //кинжал
                    return weaponDirk;
                case WeaponType.Fists:
                    Weapon weaponFists = new Weapon("Fists", 2, 2, WeaponType.Fists);   //костет
                    return weaponFists;
                case WeaponType.Stick:
                    Weapon weaponStick = new Weapon("Stick",8, 8, WeaponType.Stick);    //посох
                    return weaponStick;
                case WeaponType.Sword:
                    Weapon weaponSword = new Weapon("Sword", 12, 12, WeaponType.Sword); //меч
                    return weaponSword;
                case WeaponType.Null:
                    Weapon weaponNull = new Weapon("Null", 0, 0, WeaponType.Null);
                    return weaponNull;
                default:
                    weaponNull = new Weapon("Null", 0, 0, WeaponType.Null);
                    return weaponNull;
            }
        }
        public static Magic MakingMagic(TypesOfMagic type)
        {
            switch (type)
            {
                case TypesOfMagic.Arrow:
                    Magic magicArrow = new Magic("Arrow", 5, 5, 10, TypesOfMagic.Arrow);  // Стрела
                    return magicArrow;
                case TypesOfMagic.Fireball:
                    Magic magicFireball = new Magic("Fireball", 7, 7, 15, TypesOfMagic.Fireball);  // Файрбол
                    return magicFireball;
                case TypesOfMagic.Fist:
                    Magic magicFist = new Magic("Fist", 2, 2, 5, TypesOfMagic.Fist);  // Кулак
                    return magicFist;
                case TypesOfMagic.Lightning:
                    Magic magicLightning = new Magic("Lightning", 10, 10, 20, TypesOfMagic.Lightning); // Молния
                    return magicLightning;
                case TypesOfMagic.Rock:
                    Magic magicRock = new Magic("Rock", 15, 15, 30, TypesOfMagic.Rock); // Камнепад
                    return magicRock;
                case TypesOfMagic.Null:
                    Magic magicNull = new Magic("Null", 0, 0, 0, TypesOfMagic.Null);
                    return magicNull;
                default:
                    magicNull = new Magic("Null", 0, 0, 0, TypesOfMagic.Null);
                    return magicNull;
            }
        }
    }
}
