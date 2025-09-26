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

    public int CountForFirstDays(int numberOfDays)
    {
        int totalCount = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            totalCount += birdsPerDay[i];
        }
        return totalCount;
    }

    public int BusyDays()
    {
        int busyCount = 0;
        foreach (int bird in birdsPerDay)
        {
            if(bird >= 5)
            {
                busyCount++;
            }
        }
        return busyCount;
    }
}
