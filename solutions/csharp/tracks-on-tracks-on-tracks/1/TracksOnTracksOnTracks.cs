public static class Languages
{
    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages()
    {
        List<string> languages = new List<string>();
        
        languages.Add("C#"); 
        languages.Add("Clojure");
        languages.Add("Elm");

        return languages;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count();
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count() == 0)
        {
            return false;
        }
        else
        {
            if(languages[0] == "C#" || languages[1] == "C#" && (languages.Count() == 2 || languages.Count() == 3))
                {return true;}
            else {return false;}
        }

    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        List<string> seen = new List<string>();
        
        foreach(string language in languages)
        {
            if (seen.Contains(language))
            {
                return false;
            }
            seen.Add(language);
        }
        return true;
    }
}
