using System;

namespace FirstNameSpace
{
    public static class StringExtensions
    {
        public static string FirstLetterUpperCase(this string word)
        {
            char letter = Char.ToUpper(word[0]);
            string remaining = word.Substring(1);
            return letter + remaining;
        }
    }
}
