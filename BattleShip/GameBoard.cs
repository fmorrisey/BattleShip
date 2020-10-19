using RPSLS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    /// <summary>
    /// 
    /// </summary>

    class GameBoard
    {
        // Member Variables // Global GameBoard Variables
        public ShipYard ShipYard;
        Menu Menu;
        Logic Logic;

        public char[,] player01_TrackingGrid;   //Holds the player's ships
        public char[,] player02_TrackingGrid;
                      
        // Constructor
        public GameBoard()
        {
            Menu = new Menu();
            Logic = new Logic();

            player01_TrackingGrid = new char[20, 20];
            player02_TrackingGrid = new char[20, 20];

        }

        /// Member Methods ///

        
        // Start Game //
        public void StarGame()
        {   //This will later be replaced by the menu class
            Console.WriteLine("GAME START");
            
        }
        // Require a load screen

        // Main Menu //
            // Menu.DisplayMainMenu
            // Menu.DisplayRules
            // input validation // Logic.MainMenuSelection(int);
        public void InitializeMainMenu()
        {   //Initial Menu // Handles all the background logic for the main menu 
            int PlayerMenuChoice;
            bool askAgain = false;

            //MENU LOOP
            do
            {
                //MAIN MENU//
                Menu.DrawMainMenu();                            // Draws Main menu
                PlayerMenuChoice = Logic.MainMenuSelection();   // Asks the player to make selection
                switch (PlayerMenuChoice)                       // Player's choice activate switch
                {
                    case 1:
                        {
                            //PlayerSelection();                  // Select Players, creates Player1/2 Object collection
                            //RunGame();                          // Runs the gesture game
                            askAgain = true; break;
                        }

                    case 2: Menu.DisplayeRules(); askAgain = true; break; // Selection to draw menu rules
                    case 3: askAgain = false; break;            //Exits the game
                    default:
                        Console.WriteLine("ERORR 400: Not a Valid Selection");
                        askAgain = false;
                        break;
                }
            } while (askAgain == true);

        }


        ////// Naval Battle Field //////

        /// Core Game Package
            // Turn tracking //
            // bool isPlayer1Turn; // Logic.TurnTracking()

        // Grid Coordinates //
            // Target Grid (Enemy ships)
            // Tracking Grid (Friendly ships)

        // Artillery //
            // validation for coordinates
            // hit miss checker
            // score keeping for hits


        // End game //
        // Score determination
        // 


    }
}
