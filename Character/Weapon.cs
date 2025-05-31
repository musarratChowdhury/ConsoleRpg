namespace ConsoleRpg.Character;

public class Weapon
{
    public Weapon(double baseDamage, double critChance, double critPercentage, string name)
    {
        BaseDamage = baseDamage;
        CritChance = critChance;
        CritPercentage = critPercentage;
        Name = name;
    }

    public string Name { get; set; }
    public double BaseDamage { get; set; }
    public double CritChance { get; set; }
    public double CritPercentage { get; set; }
}