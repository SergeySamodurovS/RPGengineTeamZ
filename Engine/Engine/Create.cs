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
                    Equipment equipmentLight = new Equipment("Light", 5, 5, Equipment.EquipmentType.Light);
                    return equipmentLight;
                case 2:
                    Equipment equipmentMedium = new Equipment("Medium", 10, 10, Equipment.EquipmentType.Medium);
                    return equipmentMedium;
                case 3:
                    Equipment equipmentHeavy = new Equipment("Heavy", 15, 15, Equipment.EquipmentType.Heavy);
                    return equipmentHeavy;
                case 4:
                    Equipment equipmentVeryHard = new Equipment("VeryHard", 20, 20, Equipment.EquipmentType.VeryHard);
                    return equipmentVeryHard;
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
                    Weapon weaponBow = new Weapon("Bow", 10, 5, Weapon.WeaponType.Bow);//лук
                    return weaponBow;
                case 2:
                    Weapon weaponDirk = new Weapon("Dirk", 5, 5, Weapon.WeaponType.Dirk);//кинжал
                    return weaponDirk;
                case 3:
                    Weapon weaponFists = new Weapon("Fists", 5, 5, Weapon.WeaponType.Fists);//кулаки
                    return weaponFists;
                case 4:
                    Weapon weaponStick = new Weapon("Stick", 5, 5, Weapon.WeaponType.Stick);//посох
                    return weaponStick;
                case 0:
                    Weapon weaponSword = new Weapon("Sword", 5, 5, Weapon.WeaponType.Sword);//меч
                    return weaponSword;
                default:
                    Weapon weaponDefault = new Weapon("Fists", 5, 5, Weapon.WeaponType.Fists);//кулаки
                    return weaponDefault;
            }
        }


    }
}
