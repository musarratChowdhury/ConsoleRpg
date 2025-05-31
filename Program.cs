
using ConsoleRpg.Character;

var axe = new Hero("Axe", 1000, 50, 100, 20); //initialization -> to create an instance of a class
var dragonKnight = new Hero("Dragon Knight", 1200, 54, 150, 10);

var ironSword = new Weapon(80, 20, 50, "iron_sword");
Console.WriteLine(dragonKnight.BaseDamage);
dragonKnight.EquipWeapon(ironSword);
Console.WriteLine("after equiping iron sword "+ dragonKnight.BaseDamage);

//creating a new armour
var bronzeBreastPlate = new Armour(50, 20, "bronzeBreastPlate");

//the dragon knight will equip this armour
Console.WriteLine("Armour before equiping the bronze plate "+ dragonKnight.BaseArmour);
dragonKnight.EquipArmour(bronzeBreastPlate);
Console.WriteLine("Armour after equiping the bronze plate "+ dragonKnight.BaseArmour);

var goblin = new Monster("Goblin", 200, 200, 100, 10);

axe.Take_Damage(goblin.BaseDamage);
axe.Take_Damage(goblin.BaseDamage);

dragonKnight.Take_Damage(400);
goblin.Take_Damage(200);


Console.WriteLine(axe.HP);
Console.WriteLine("Dragon Knights hp "+dragonKnight.HP);

// Console.WriteLine(axe.Name + " has armour = "+ axe.Armour);
// Console.WriteLine(goblin.Name + " has armour = "+ goblin.Armour);