using ConsoleRpg.Character.SuperClass;

namespace ConsoleRpg.Character;

public class Monster : Actor
{
    public Monster(string name, int hp, int bDamage, int baseArmour, int hpGenRate) : base(name, hp, bDamage, baseArmour,
        hpGenRate)
    {
    }
}