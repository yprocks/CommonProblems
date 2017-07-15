using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    class RabinKarpMatching
    {
        private const int PRIME = 3;
        private char[] Characters { get; set; }

        public RabinKarpMatching()
        {
            Characters = new char[91];
            for (int i = 0, k = 31; i < Characters.Length; i++, k++)
                Characters[i] = (char)k;
        }

        public bool MatchString(string text, string pattern)
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
    }
}
