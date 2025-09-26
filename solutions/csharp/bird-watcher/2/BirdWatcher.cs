class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int [] birdsPerDay = {0, 2, 5, 3, 7, 8, 4};
        return birdsPerDay;
    }


    public int Today() => birdsPerDay[^1];


    public void IncrementTodaysCount() => birdsPerDay[^1] ++;


    public bool HasDayWithoutBirds()
    {
        foreach (int bird in birdsPerDay)
        {
            if (bird == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays) => birdsPerDay.Take(numberOfDays).Sum();

    public int BusyDays() =>  birdsPerDay.Count(bird => bird >= 5);
}
