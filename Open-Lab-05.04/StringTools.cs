using System;
using System.Globalization;

namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original)
        {
            string res = String.Empty;
            for (int i = 0; i < original.Length; i++)
            {
                if ( original[i] == '-' || original[i] == '_'|| original[i] == ' ' || Char.IsLetter(original[i]) || Char.IsDigit(original[i]))
                {
                    res += original[i];
                }

            }
            return res;
        }
    }
}
