static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0) return 0;
        else if (speed <= 4) return 1;
        else if (speed <= 8) return 0.9;
        else if (speed == 9) return 0.8;
        else if (speed == 10) return 0.77;

            throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int singleRate = 221;

        double success = SuccessRate(speed);

        double perHour = (speed * singleRate) * success;
        return perHour;

        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int singleRate = 221;
        int perMinute = (int)(singleRate * speed*SuccessRate(speed))/60;
        return perMinute;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
