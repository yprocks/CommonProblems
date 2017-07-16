using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    class StringMatching
    {

        private const int PRIME = 3;

        public bool RabinKarpPatternMatching(string text, string pattern)
        {
            int hash = FindHash(pattern);
            int oldHash = -1;
            string stringToCompare = "";
            char oldChar = ' ';
            for (int i = 0; i < text.Length - (pattern.Length - 1); i++)
            {
                for (int j = 0; j < pattern.Length; j++)
                    stringToCompare += text[i + j];
                //int hashToMatch = FindHash(stringToCompare);
                int hashToMatch = FindHash(stringToCompare, oldHash, oldChar);
                if (hash == hashToMatch) return true;
                oldHash = hashToMatch;
                oldChar = stringToCompare[0];
                stringToCompare = "";
            }

            return false;
        }

        private int FindHash(string s)
        {
            int x = 0;
            for (int i = 0; i < s.Length; i++)
                x += (s[i] - 96) * (int)Math.Pow(PRIME, i);
            return x;
        }

        private int FindHash(string s, int oldHash, char oldChar)
        {
            if (oldHash == -1)
                return FindHash(s);

            int x = oldHash - (oldChar - 96);
            x = x / PRIME;
            int hashValue = x + ((s[s.Length - 1] - 96) * (int)Math.Pow(PRIME, s.Length - 1));

            return hashValue;
        }

        public bool NaiveStringMatching(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length - 1;

            for (int i = 0; i < n - m; i++)
            {
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (pattern[j] != text[j + i])
                        break;
                    if (j == m)
                        return true;
                }
            }
            return false;
        }

        public bool KnuthMorrisPatternMatching(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length - 1;
            int[] prefix = GetPrefix(pattern);
            int i = 0, j = 0;
            
            while (i < text.Length && j < pattern.Length)
            {
                if (pattern[j] == text[i])
                {
                    i++;
                    j++;
                }
                else if (j != 0) j = prefix[j - 1];
                else i++;

                if (j == pattern.Length)
                    return true;
            }
            return false;
        }

        private int[] GetPrefix(string pattern)
        {
            int[] prefix = new int[pattern.Length];
            prefix[0] = 0;
            int i = 1;
            for (int j = 0; j < pattern.Length; j++)
                while (i < pattern.Length)
                {
                    if (pattern[i] == pattern[j])
                    {
                        prefix[i] = j + 1;
                        i++; j++;
                    }
                    else if (j == 0)
                    {
                        prefix[i] = 0;
                        i++;
                    }
                    else
                    {
                        int temp = j - 1;
                        j = prefix[temp];
                    }
                }
            return prefix;
        }

    }
}
