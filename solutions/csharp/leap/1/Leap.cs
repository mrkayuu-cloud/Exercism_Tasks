public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if (year % 100 == 0 && year % 400 == 0) return true;
        else if (year % 100 == 0 && year % 400 > 0) return false;
        else if (year % 4 == 0) return true;
        return false;
        throw new NotImplementedException("You need to implement this method.");
    }
}