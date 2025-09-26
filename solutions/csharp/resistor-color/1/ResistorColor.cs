enum resColours
    {
        black = 0,
        brown = 1,
        red = 2,
        orange = 3,
        yellow = 4,
        green = 5,
        blue = 6,
        violet = 7,
        grey = 8,
        white = 9
    }
        
public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        switch (color)
        {
            case "black":
                return (int)resColours.black;
            case "brown":
                return (int)resColours.brown;
            case "red":
                return (int)resColours.red;
            case "orange":
                return (int)resColours.orange;
            case "yellow":
                return (int)resColours.yellow;
            case "green":
                return (int)resColours.green;
            case "blue":
                return (int)resColours.blue;
            case "violet":
                return (int)resColours.violet;
            case "grey":
                return (int)resColours.grey;
            case "white":
                return (int)resColours.white;
            default:
                return -1;
        };
    }

    public static string[] Colors()
    {
        return Enum.GetNames(typeof(resColours));
    }
}