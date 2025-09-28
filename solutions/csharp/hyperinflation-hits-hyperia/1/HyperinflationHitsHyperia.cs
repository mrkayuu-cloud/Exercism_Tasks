﻿public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            checked
            {
                return $"{@base * multiplier}";
            }
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        } 
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        if(float.IsInfinity(@base * multiplier))
        {
            return "*** Too Big ***";
        }
        return $"{@base * multiplier}";
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            checked
            {
                return $"{salaryBase * multiplier}";
            }
        }
        catch (OverflowException)
        {
            return "*** Much Too Big ***";
        }
    }
}
