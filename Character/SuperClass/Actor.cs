namespace ConsoleRpg.Character.SuperClass;

public class Actor
{
    public Actor(string name, int hp, int bDamage, int baseArmour, int hpGenRate)
    {//constructor method
        Name = name;
        HP = hp;
        BaseDamage = bDamage;
        BaseArmour = baseArmour;
        HpRegenerationRate = hpGenRate;
    }
    
    public string Name { get; set; } = "";
    public double HP { get; set; }
    public double BaseDamage {get; set; }
    public int BaseArmour { get; set; }
    public double HpRegenerationRate { get; set; }
    
    public double Take_Damage(double _dmg)
    {
        double damageReducedByArmour = _dmg - BaseArmour;
        HP = HP - damageReducedByArmour;
        return HP;
    }
    
}