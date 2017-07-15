using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // BackTrackQueenProblem q = new BackTrackQueenProblem(4);
            // q.Solution();
            // q.Print();

            NaiveStringMatching mat = new NaiveStringMatching();
            bool res = mat.MatchString("This is my own text", "is");
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
