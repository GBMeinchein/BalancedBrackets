using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class BalancedBrackets
    {
        public static bool IsBalancedBrackets(string brackets)
        {
            string lastCharacter = string.Empty;
            List<string> lstOpenBrackets = new List<string>();
            string bracketsOnly = BracketsOnly(brackets);

            if (bracketsOnly.Length <= 0)
                return false;

            for (int i = 0; i < bracketsOnly.Length; i++)
            {
                var character = bracketsOnly.Substring(i, 1);

                if (IsOpenBracket(character))
                    lstOpenBrackets.Add(character);
                else if (!lstOpenBrackets.Any())
                {
                    return false;
                }
                else
                {
                    if (!string.IsNullOrEmpty(lstOpenBrackets.Last()) && CloseBracketOf(lstOpenBrackets.Last()) != character)
                        return false;
                    else
                        lstOpenBrackets.Remove(lstOpenBrackets.Last());
                }

                lastCharacter = character;
            }

            if (lstOpenBrackets.Any())
                return false;
            else
                return true;
        }

        private static bool IsOpenBracket(string character)
        {
            const string openChars = "{[(";

            if (openChars.Contains(character))
                return true;

            return false;
        }

        private static string CloseBracketOf(string openBracket)
        {
            switch (openBracket)
            {
                case "(":
                    return ")";
                case "[":
                    return "]";
                case "{":
                    return "}";
                default:
                    return string.Empty;
            }
        }

        private static string BracketsOnly(string character)
        {
            string bracketsOnly = string.Empty;
            string brackets = "[]{}()";
            for (int i = 0; i < character.Length; i++)
            {
                if (brackets.Contains(character[i]))
                    bracketsOnly += character[i];
            }
            return bracketsOnly;
        }
    }
}
