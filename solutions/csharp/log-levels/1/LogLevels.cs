using System.Text;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(":")[1].Trim();

        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf("[")+1;
        int endIndex = logLine.IndexOf("]");

        if (startIndex >= 0 && endIndex > startIndex)
        {
            string logLevel = logLine.Substring(startIndex, endIndex - startIndex).ToLower();
            return logLevel;
        }

        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);

        return $"{message} ({level})";


        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
