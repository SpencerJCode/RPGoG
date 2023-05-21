public class Weapon
{
    public string Name { get; set; } = "";
    public int Damage { get; set; } = 0;
    public bool IsTwoHanded { get; set; } = false;
    public int CriticalRate { get; set; } = 20;
    public int Value { get; set; } = 10;
    public Weapon(string _Name, int _Damage, bool _IsTwoHanded, int _CriticalRate, int _Value)
    {
        Name = _Name;
        Damage = _Damage;
        IsTwoHanded = _IsTwoHanded;
        CriticalRate = _CriticalRate;
        Value = _Value;
    }
}