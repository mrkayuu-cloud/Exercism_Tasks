static class SavingsAccount
{
    public static float InterestRate(decimal balance) => balance < 0m ? 3.213f : balance < 1000m ? 0.5f : balance >= 1000m && balance < 5000m ? 1.621f : 2.475f;

    public static decimal Interest(decimal balance) =>  balance * (decimal)(InterestRate(balance)/100);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int yearsElapsed = 0;
        do
        {
            balance += Interest(balance);
            yearsElapsed++;
        } while (balance < targetBalance);

        return yearsElapsed;
    }
}
