public static class Identifier
{
    public static string Clean(string identifier)
    {
        int hyphenIndex = identifier.IndexOf("-")+1;

        if (identifier.Contains("-"))
        {
            char[] word = identifier.ToCharArray();
            word[hyphenIndex]=char.ToUpper(word[hyphenIndex]);
    
            identifier = new string(word);
        }

        identifier = identifier.Replace(" ", "_")
                               .Replace("-","")
                               .Replace("\0", "CTRL");

        identifier = new string(identifier
                                .Where(c =>
                                       (char.IsLetter(c) && !IsGreekLetter(c))
                                       || c == ' '
                                       || c == '_')
                                .ToArray());
                                    ;
        return identifier;
    }

    private static bool IsGreekLetter(char c)
    {
        return (c >= 'α' && c <= 'ω') && c != 'Ο';
    }
}
