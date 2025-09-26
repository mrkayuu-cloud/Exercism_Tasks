using System.Numerics;

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int ovenTime = 40;
        return ovenTime;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeInOven)
    {
        int remainingTime = 40 - timeInOven;
        return (remainingTime);
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        int prepTime = layers * 2;
        return prepTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        int prepTime = PreparationTimeInMinutes(layers);
        int elapsedTime = minutesInOven + prepTime;

        return elapsedTime;
    }
}

