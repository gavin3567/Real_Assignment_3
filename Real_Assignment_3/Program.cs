using System;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Threading;

namespace Mission3
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            // playGame is a bool that initializes as true and will turn false when the user says no to playing another game
            bool playGame = true;
            // while loop that runs the program while playGame is true
            while (playGame == true)
            {
                // initialized userName variable
                string player1 = "";
                string player2 = "";

                // Create an array to store the positions of the board from 1-9
                char[] positions = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '9' };

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

                // the windCondition is a char that will initialize with the value of 'F' (false)
                // that represents whether there is a winner or not
                char winCondition = 'F';

                // goodChoice is a bool that represents whether the current player has selected a position on the board that is available or not
                bool goodChoice = false;

                // turnCount counts the number of good choices made by players (up to 9) to keep track of how many turns are left in the game  
                int turnCount = 0;

                //Start the game while loop
                while (winCondition == 'F' && turnCount < 9)
                {

                    // Asks player 1 during their turn for their choice and update the game board array (with X)
                    if (playerTurn == 1)
                    {
                        // goodChoice remains false until the user selects a position that is open to play in
                        goodChoice = false;

                        // while loop that prints it is player 1's turn and asks them where to place their X
                        while (goodChoice == false)
                        {
                            Console.WriteLine("It's " + player1 + "'s turn");
                            // calls the Print method from the Support class with the positions array as a parameter
                            Support.Print(positions);

                            // Prompts for the position, reads the input, and converts it to an int 
                            Console.WriteLine("Choose where you want to place your X");
                            string userChoice = Console.ReadLine();
                            int choice = int.Parse(userChoice);

                            // checks the positions array if the choice made by the user is already an 'X' or an 'O' 
                            if (positions[choice-1] != 'X' && positions[choice-1] != 'O')
                            {
                                // changes the char value that equates to the position (f.g '5') to an 'X'
                                positions[choice-1] = 'X';
                                // switches the bool to true to end the while loop
                                goodChoice = true;
                            }
                        }
                    }


                    // Asks player 2 during their turn for their choice and update the game board array (with O)
                    if (playerTurn == 2)
                    {
                        // goodChoice remains false until the user selects a position that is open to play in
                        goodChoice = false;

                        // while loop that prints it is player 2's turn and asks them where to place their O
                        while (goodChoice == false)
                        {
                            Console.WriteLine("It's " + player2 + "'s turn");
                            // calls the Print method from the Support class with the positions array as a parameter
                            Support.Print(positions);

                            // Prompts for the position, reads the input, and converts it to an int 
                            Console.WriteLine("Choose where you want to place your O");
                            string userChoice = Console.ReadLine();
                            int choice = int.Parse(userChoice);

                            // checks the positions array if the choice made by the user is already an 'X' or an 'O' 
                            if (positions[choice-1] != 'X' && positions[choice-1] != 'O')
                            {
                                // changes the char value that equates to the position (f.g '5') to an 'O'
                                positions[choice-1] = 'O';

                                // switches the bool to true to end the while loop
                                goodChoice = true;
                            }
                        }
                    }
                    // break line between user prompts
                    Console.WriteLine("\n");

                    // Check for a winner by calling the method in the supporting class
                    winCondition = Support.Check(positions);

                    // switches users based on the result of a % 
                    // if 1 then it becomes player 2's turn
                    if (playerTurn % 2 == 1)
                    {
                        playerTurn = 2;
                    }
                    // if 2 then it becomes player 1's turn
                    else if (playerTurn % 2 == 0)
                    {
                        playerTurn = 1;
                    }
                    // increment turnCount by 1
                    turnCount++;
                }

                string winner = "Spencer Hilton";

                if (winCondition == 'X')
                {
                    winner = player1;
                }
                else if (winCondition == 'O')
                {
                    winner = player2;
                }

                // Notify the players when a win has occurred and which player won the game
                Console.WriteLine("Congrats " + winner + " for winning this round of online Tic-Tac-Toe on turn " + turnCount + "!");

                // Prompt user if they want to play again
                bool userOption = true;
                while (userOption == true)
                {
                    Console.WriteLine("Would you like to play again? Enter Y or N: ");
                    string userChoice = Console.ReadLine();

                    if (userChoice == "N" || userChoice == "n")
                    {
                        playGame = false;
                        userOption = false;
                    }
                    else if (userChoice == "Y" || userChoice == "y")
                    {
                        playGame = true;
                        userOption = false;
                    }
                    else
                    {
                        Console.WriteLine("You will be trapped forever in a loop if you keep answering incorrectly!");
                    }


                }
                
                
            }
        }
    }
}

// 1-9 options
// Add a condition to allow the players to play again