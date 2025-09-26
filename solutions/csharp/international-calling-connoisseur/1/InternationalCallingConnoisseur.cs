public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new Dictionary<int, string>();

    public static Dictionary<int, string> GetExistingDictionary()
    {
        var countryDict = new Dictionary<int, string>
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India"}
        };
        return countryDict;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var emptyDict = new Dictionary<int, string>()
        {
            {countryCode, countryName}
        };

        return emptyDict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        try 
        {
            return existingDictionary[countryCode];
        }
        catch (KeyNotFoundException)
        {
            return string.Empty;
        }
        
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        if(!existingDictionary.ContainsKey(countryCode))
        {
            return false;
        }
        return true;
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if(!CheckCodeExists(DialingCodes.GetExistingDictionary(),countryCode)) {return existingDictionary;}
        if(GetCountryNameFromDictionary(DialingCodes.GetExistingDictionary(),countryCode) != null)
        {
            existingDictionary[countryCode] = countryName;
        }
        
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longest = "";
        
        foreach (var kvp in existingDictionary)
        {
            if (kvp.Value.Length > longest.Length)
            {
                longest = kvp.Value;
            }
        }
        return longest;

        
    }
}