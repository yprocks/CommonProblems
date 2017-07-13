using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    class BackTrackQueenProblem
    {
        private readonly char QUEENCHAR = 'Q';

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
            SolveProblem(0, Board);
        }

        private bool SolveProblem(int col, char[][] board)
        {
            if (col >= Size)
                return true;

            for (int i = 0; i < board.Length; i++)
                if (PlaceQueen(board, i, col))
                {
                    board[i][col] = QUEENCHAR;
                    if (SolveProblem(col + 1, board))
                        return true;
                    board[i][col] = ' ';
                }
            return false;
        }

        private bool PlaceQueen(char[][] board, int row, int col)
        {
            int i, j;

            // Check Row Victim (Do not need to check further)
            for (i = 0; i < col; i++)
                if (board[row][i] == QUEENCHAR)
                    return false;

            // Check digonal Victim -- 
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i][j] == QUEENCHAR)
                    return false;

            // Check diagonal Victim +-
            for (i = row, j = col; i < Size && j >= 0; i++, j--)
                if (board[i][j] == QUEENCHAR)
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
                if (i < 9)
                    Console.Write(" ");
                Console.Write((i + 1) + " ");
                for (int j = 0; j < Board[i].Length; j++)
                {
                    if (j > 9)
                        Console.Write(" ");
                    if (Board[i][j] == QUEENCHAR)
                        Console.Write(Board[i][j] + " ");
                    else
                        Console.Write("- ");
                }
                Console.WriteLine();
            }
        }
    }
}
