using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    class BackTrackQueenProblem
    {
        public char[][] Board { get; set; }
        public int Size { get; set; }

        public BackTrackQueenProblem(int board)
        {
            Size = board;
            Board = new char[board][];
            for (int i = 0; i < Board.Length; i++)
                Board[i] = new char[board];
        }

        public void Solution()
        {
            SolveProblem(0);
        }

        private bool SolveProblem(int col)
        {
            if (col >= Size)
                return true;

            for (int i = 0; i < Board.Length; i++)
                if (PlaceQueen(i, col))
                {
                    Board[i][col] = 'Q';
                    if (SolveProblem(col + 1))
                        return true;
                    Board[i][col] = ' ';
                }


            return false;
        }

        private bool PlaceQueen(int row, int col)
        {
            int i, j;

            // Check Row Victim (Do not need to check further)
            for (i = 0; i < col; i++)
                if (Board[row][i] == 'Q')
                    return false;

            // Check digonal Victim -- 
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (Board[i][j] == 'Q')
                    return false;

            // Check diagonal Victim +-
            for (i = row, j = col; i < Size && j >= 0; i++, j--)
                if (Board[i][j] == 'Q')
                    return false;

            return true;
        }

        public void Print()
        {
            Console.Write("  ");
            for (int k = 0; k < Size; k++)
                Console.Write((k + 1) + " ");

            Console.WriteLine();

            for (int i = 0; i < Board.Length; i++)
            {
                Console.Write((i + 1) + " ");
                for (int j = 0; j < Board[i].Length; j++)
                    Console.Write(Board[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}
