using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class Create
    {
        public static Equipment MakingEquipment(int name)
        {

            switch (name)
            {
                case 1:
                    Equipment equipmentHelmet = new Equipment("Helmet", 10, 15, Equipment.EquipmentType.Helmet);//Шлем
                    return equipmentHelmet;
                case 2:
                    Equipment equipmentСuirass = new Equipment("Сuirass", 15, 20, Equipment.EquipmentType.Сuirass);//Кираса
                    return equipmentСuirass;
                case 3:
                    Equipment equipmentLeggings = new Equipment("Heavy", 8, 10, Equipment.EquipmentType.Leggings);//Поножи
                    return equipmentLeggings;
                case 4:
                    Equipment equipmentGloves = new Equipment("VeryHard", 8, 10, Equipment.EquipmentType.Gloves);//Перчатки
                    return equipmentGloves;
                case 0:
                    Equipment equipmentNull = new Equipment("Null", 0, 0, Equipment.EquipmentType.Null);
                    return equipmentNull;
                default:
                    Equipment equipmentdefault = new Equipment("Null", 0, 0, Equipment.EquipmentType.Null);
                    return equipmentdefault;
            }
        }
        public static Weapon MakingWeapon(int name)
        {

            switch (name)
            {
                case 1:
                    Weapon weaponBow = new Weapon("Bow", 10, 10, Weapon.WeaponType.Bow);//лук
                    return weaponBow;
                case 2:
                    Weapon weaponDirk = new Weapon("Dirk", 5, 5, Weapon.WeaponType.Dirk);//кинжал
                    return weaponDirk;
                case 3:
                    Weapon weaponFists = new Weapon("Fists", 2, 0, Weapon.WeaponType.Fists);//кулаки
                    return weaponFists;
                case 4:
                    Weapon weaponStick = new Weapon("Stick",8, 8, Weapon.WeaponType.Stick);//посох
                    return weaponStick;
                case 0:
                    Weapon weaponSword = new Weapon("Sword", 12, 12, Weapon.WeaponType.Sword);//меч
                    return weaponSword;
                default:
                    Weapon weaponDefault = new Weapon("Fists", 2, 0, Weapon.WeaponType.Fists);//кулаки
                    return weaponDefault;
            }
        }


    }
}
