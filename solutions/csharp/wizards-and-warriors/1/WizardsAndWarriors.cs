abstract class Character
{
    public string cType;
    
    protected Character(string characterType) => this.cType = characterType;

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {this.cType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
        {
            return 10;
        }
        return 6;
    }
}

class Wizard : Character
{
    public bool spell;
    private bool state = true;
    private int damage;
    
    public Wizard() : base("Wizard")
    {
        this.spell = false;
    }

    public override int DamagePoints(Character target)
    {
        if (this.spell == true)
        {
            return 12;
        }
        return 3;
    }
    

    public void PrepareSpell()
    {
        this.spell = true;
        this.state = !state;
    }

    public override bool Vulnerable() => state;
}
