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

            //StringMatching mat = new StringMatching();
            //bool res = mat.NaiveMatchString("This is my own text", "is");
            //Console.WriteLine(res);

            //bool res = mat.RabinKarpMatchString("abskabacmgdyl;", "bac");
            //Console.WriteLine(res);

            //bool res = mat.KnuthMorrisPatternMatching("abxabcabcaby", "abcaby");
            //Console.WriteLine(res);

            //TowersOfHannoi toh = new TowersOfHannoi();
            //toh.Solve(3);

            int[] array = { 9, 6, 4, 8, 1, 2, 7};
            var srt = new SortingAlgorithms();
            int[] sortedarray = srt.MergeSort(array);

            Console.WriteLine("\nAfter Sorting");
            for (int i = 0; i < sortedarray.Length; i++)
                Console.Write(sortedarray[i] + " ");

            Console.ReadLine();
        }
    }
}
