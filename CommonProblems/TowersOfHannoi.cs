using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    class TowersOfHannoi
    {

        private const char END = 'C';
        private const char BEG = 'A';
        private const char AUX = 'B';

        public void Solve(int disks)
        {
            Console.WriteLine("Moves " + disks + " disks from " + BEG + " to " + END + " with help of spare disk " + AUX);
            SolveHanoi(disks, BEG, AUX, END);
        }

        private void SolveHanoi(int disks, char Beg, char Aux, char End)
        {
            if (disks == 1)
            {
                Console.WriteLine("Disk Moved " + Beg + " -> " + End);
                return;
            }

            SolveHanoi(disks - 1, Beg, End, Aux);
            SolveHanoi(1, Beg, Aux, End);
            SolveHanoi(disks - 1, Aux, Beg, End);
        }
    }
}
