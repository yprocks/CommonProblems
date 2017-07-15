using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    class NaiveStringMatching
    {

        public bool MatchString(string text, string pattern)
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
    }
}
