static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate)
    {
        if (appointmentDate >= DateTime.Now)
        {
            return false;
        }
        return true;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
        {
            return true;
        }
        return false;
    }

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToString("G")}.";

    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
}
