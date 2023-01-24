using System;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Threading;

namespace Driver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool playGame = true;
            while (playGame == true)
            {
                // initialized userName variable
                string player1 = "";
                string player2 = "";

                // Create a game board array to store the players’ choices
                char[] positions = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                // initialize the board

                static void Board(char[] positions)
                {
                    Console.WriteLine("     |     |      ");
                    Console.WriteLine("  {0}  |  {1}  |  {2}", positions[1], positions[2], positions[3]);
                    Console.WriteLine("_____|_____|_____ ");
                    Console.WriteLine("     |     |      ");
                    Console.WriteLine("  {0}  |  {1}  |  {2}", positions[4], positions[5], positions[6]);
                    Console.WriteLine("_____|_____|_____ ");
                    Console.WriteLine("     |     |      ");
                    Console.WriteLine("  {0}  |  {1}  |  {2}", positions[7], positions[8], positions[9]);
                    Console.WriteLine("     |     |      ");
                }

                // prompt user for name of player 1
                Console.WriteLine("What is player 1's name?");

                // store name in userName variable
                player1 = Console.ReadLine();

                // prompt user for name of player 2
                Console.WriteLine("What is player 2's name?");

                // store name in userName variable
                player2 = Console.ReadLine();

                // Welcome the user to the game
                Console.WriteLine("Welcome " + player1 + " and " + player2 + " to the online Tic-Tac-Toe game!");

                // Generate random number to decide who goes first
                // 1 represents Player One, 2 represents Player Two
                Random random = new Random();
                double playerTurn = random.Next(1, 3);

                char winCondition = 'F';
                bool goodChoice = false;
                int turnCount = 0;

                //Start the game while loop
                while (winCondition == 'F' && turnCount < 9)
                {

                    // Ask each player in turn for their choice and update the game board array
                    if (playerTurn == 1)
                    {
                        goodChoice = false;
                        while (goodChoice == false)
                        {
                            Console.WriteLine("It's " + player1 + "'s turn");
                            Board(positions);
                            Console.WriteLine("Choose where you want to place your X");
                            string userChoice = Console.ReadLine();
                            int choice = int.Parse(userChoice);
                            if (positions[choice] != 'X' && positions[choice] != 'O')
                            {
                                positions[choice] = 'X';
                                goodChoice = true;
                            }
                        }
                    }


                    if (playerTurn == 2)
                    {
                        goodChoice = false;
                        while (goodChoice == false)
                        {

                            Console.WriteLine("It's " + player2 + "'s turn");
                            Board(positions);
                            Console.WriteLine("Choose where you want to place your O");
                            string userChoice = Console.ReadLine();
                            int choice = int.Parse(userChoice);
                            if (positions[choice] != 'X' && positions[choice] != 'O')
                            {
                                positions[choice] = 'O';
                                goodChoice = true;
                            }
                        }
                    }

                    Console.WriteLine("\n");



                    // Print the board by calling the method in the supporting class

                    // Check for a winner by calling the method in the supporting class


                    for (int i = 0; i <= positions.Length - 1; i++)
                    {
                        Console.WriteLine(positions[i]);
                    }

                    if (playerTurn == 1)
                    {
                        playerTurn = 2;
                    }
                    else
                    {
                        playerTurn = 1;
                    }

                    turnCount++;
                }

                // Notify the players when a win has occurred and which player won the game
            }
        }
    }
}

// 1-9 options
// Add a condition to allow the players to play again