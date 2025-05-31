using ConsoleRpg.Character.SuperClass;

namespace ConsoleRpg.Character;

public class Hero : Actor //inheritance in OOP
{
    private Weapon _equipedWeapon;
    private Armour _equipedArmour;
    
    public Hero(string name, int hp, int bDamage, int baseArmour, int hpGenRate) : base(name,hp,bDamage,baseArmour,hpGenRate)
    {

    }

    public void EquipWeapon(Weapon inputWeapon)
    {
        _equipedWeapon = inputWeapon;
        BaseDamage += _equipedWeapon.BaseDamage;
    }

    public void EquipArmour(Armour armour)
    {
        _equipedArmour = armour;
        BaseArmour += armour.baseArmour;
    }
}