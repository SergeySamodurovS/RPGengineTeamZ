# PRGengineTeamZ
Учебный репозиторий для создания игры

#### Авторы:
+ [*© Самодуров Сергей\(SergeySamodurovS\)*](https://github.com/SergeySamodurovS) - тимлид
+ [*© Рязанцев Илья\(RID1991-IT\)*](https://github.com/RID1991-IT)
+ [*© Сафарова Рената\(RenataRobertovna\)*](https://github.com/RenataRobertovna)
+ [*© Меркулов Алексей\(mnementjr\)*](https://github.com/mnementjr)

## Классы.

**1. Equipment (экипировка)**

У игрока может быть экипировка из списка: шлем, кираса, пояс, штаны, перчатки, ничего.

У каждой вещи есть свои наименование, показатель брони и стоимость покупки.

**2. Weapon (оружие)**

У игрока может быть оружие из списка: костет, меч, палка, лук, кинжал, ничего.

У каждого оружия есть свои наименование, показатель урона и стоимость покупки. 

**3. Magic (магия)**

У игрока может быть магические заклинания из списка: стрела, молния, кулак, камнепад, файрбол, ничего.

У каждого заклинания есть свои наименование, показатель урона, стоимость покупки, затраты маны.

**4. Create (создание экземляров классов)**

Создаются экземпляры классов всех видов экипировки, оружия и заклинаний. 

**5. Hero (герой)**

У героя есть свойства: имя, уровень, опыт, урон, количество монет, оружие (только одно), магическое заклинание (только одно), список экипировки (может иметь по одной вещи каждого типа), уровень здоровья, маны.

Создаётся конструктор с параметром "Имя героя". Помимо имени, остальные параметры изначально задаются по умолчанию. 

Метод BuyingEquipment позволяет покупать экипировку, если достаточно средств, и у игрока ещё нет такого типа экипировки.

Метод BuyingWeapons позволяет покупать оружие, если достаточно средств.

Метод BuyingMagic позволяет покупать магическое заклинание, если достаточно средств.

Метод AliveOrDead проверяет жив ли останется игрок после получения очередной порции урона.

**6. Другие классы**

Классы Experience, Health, Items, Mana являются заделами под более поздние расширенные версии игры.
