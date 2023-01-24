using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3SupportingClass
{
    class Support
    {
        // Print board with values given in array
        public void Print(char[] board)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }

        public char Check(char[] board)
        {
            // Initialize results to F signifing no winner
            char result = 'F';

            if (board[0] == board[1] && board[1] == board[2])
            {
                result = board[0];
            }

            else if (board[3] == board[4] && board[4] == board[5])
            {
                result = board[3];
            }

            else if (board[6] == board[7] && board[7] == board[8])
            {
                result = board[6];
            }

            else if (board[0] == board[3] && board[3] == board[6])
            {
                result = board[0];
            }

            else if (board[1] == board[4] && board[4] == board[7])
            {
                result = board[1];
            }

            else if (board[2] == board[5] && board[5] == board[8])
            {
                result = board[2];
            }

            else if (board[3] == board[4] && board[4] == board[5])
            {
                result = board[3];
            }

            else if (board[0] == board[4] && board[4] == board[8])
            {
                result = board[0];
            }

            else if (board[6] == board[4] && board[4] == board[2])
            {
                result = board[6];
            }


            return result;
        }
    }
}