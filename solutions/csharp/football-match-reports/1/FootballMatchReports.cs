public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch(shirtNum)
        {
            case 1:
                return "goalie";
                break;
            case 2:
                return "left back";
                break;
            case >= 3 and <= 4:
                return "center back";
                break;
            case 5:
                return "right back";
                break;
            case >= 6 and <= 8:
                return "midfielder";
                break;
            case 9:
                return "left wing";
                break;
            case 10:
                return "striker";
                break;
            case 11:
                return "right wing";
                break;
            default:
                return "UNKNOWN";
                break;
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch(report)
        {
            case int i:
                return $"There are {i} supporters at the match.";
                break;
            case string i:
                return i;
                break;
            case Foul:
                return "The referee deemed a foul.";
                break;
            case Injury i:
                return $"Oh no! {i.GetDescription()} Medics are on the field.";
                break;
            case Incident:
                return "An incident happened.";
                break;
            case Manager i when i.Club is null:
                return $"{i.Name}";
            case Manager i: 
                return $"{i.Name} ({i.Club})";
            default:
                return "";
                break;
        }
    }
}
