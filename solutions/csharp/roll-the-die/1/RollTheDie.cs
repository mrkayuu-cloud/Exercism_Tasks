public class Player
{
    public int RollDie()
    {
        Random roll = new() ;
        int result = roll.Next(1,19);
        return result;
    }
    
    public double GenerateSpellStrength()
    {
        Random roll = new();
        int strength = ((int)roll.NextDouble())*100;
        return strength;
    }
}
