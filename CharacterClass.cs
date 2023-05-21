public class CharacterClass
{
    public string Name { get; set; } = "";
    public int HPDieRoll { get; set; } = 4;
    public double BaseAttackBonus { get; set; } = .5;
    public bool DoubleAttack { get; set; } = false;
    public int CriticalRate { get; set; } = 20;
    public CharacterClass(string _Name, int _HPDieRoll, double _BaseAttackBonus, int _CriticalRate, bool _DoubleAttack)
    {
        Name = _Name;
        HPDieRoll = _HPDieRoll;
        BaseAttackBonus = _BaseAttackBonus;
        CriticalRate = _CriticalRate;
        DoubleAttack = _DoubleAttack;
    }
    
}