namespace ConsoleRpg.Character;

public class Armour
{
    public Armour(int baseArmour, double blockChance, string name)
    {
        this.baseArmour = baseArmour;
        this.blockChance = blockChance;
        Name = name;
    }
    public string Name { get; set; }
    public int baseArmour { get; set; }
    public double blockChance { get; set; }
}