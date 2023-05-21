public class Armor
{
    public string Name { get; set; } = "";
    public int ArmorClass { get; set; } = 0;
    public bool IsShield { get; set; } = false;
    public int Value { get; set; } = 10;
    public Armor(string _Name, int _ArmorClass, bool _IsShield, int _Value)
    {
        Name = _Name;
        ArmorClass = _ArmorClass;
        IsShield = _IsShield;
        Value = _Value;
    }
}