using RPSLS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{   /// LOGIC CLASS
    /// <summary>
    /// This class handles the bulk of the game logic
    /// user input validation
    /// and any other decision making
    /// </summary>
    
    public class Logic
    {
        // Member variables
        Menu Menu;
        
        // Constructor
        public Logic()
        {
            Menu = new Menu();
        }

        // Member Methods

        public int InputValidation()
        {
            // Asks player for their input and validates
            int userInput = 0;
            bool askAgain;

            do
            {
                if (int.TryParse(Console.ReadLine(), out userInput))    // If Integer 
                    if (userInput >= 1 && userInput <= 5)               // And Between Range
                    { return userInput; }                               // returns valid input                               
                    else { Console.WriteLine("Incorrect Input"); askAgain = true; }
                else { Console.WriteLine("Incorrect Input"); askAgain = true; }
            } while (askAgain == true);

            return userInput;
        }

        public int MainMenuSelection()
        {   // Handles Main Menu user input with validation
            int MainMenuSelection;
            bool askAgain;

            do
            {
                Console.Write("Enter a menu option: ");
                if (int.TryParse(Console.ReadLine(), out MainMenuSelection))
                { return MainMenuSelection; }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    askAgain = true;
                }
            } while (askAgain == true);

            return MainMenuSelection;
        }

        public bool TurnTracking()
        {   /// Tracks the CoreGame Turn
            // This may be replaced with do while
            bool isPlayer1Turn;
            if (true)
            {
                // Is it player 1's turn yes = true
                isPlayer1Turn = true;
            }
            else
            {
                // is it player 2's turn no = false
                isPlayer1Turn = false;
            }
            return isPlayer1Turn;
        }



    }
}
