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
            BackTrackQueenProblem q = new BackTrackQueenProblem(8);
            q.Solution();
            q.Print();

            Console.ReadLine();
        }
    }
}
