using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    /// <summary>
    /// Child class that inherits from ShipParent
    /// </summary>
    /// 
    public class Ship : ShipYard // Rename 
    {
        // Member Variables
        public string Type;
        public int HullSize;
        public int HullHeatlh;
        public char GridChar;

        // Constructor
        public Ship(string type, char gridChar, int hullSize, int hullHealth)
        {
            this.Type = type;
            this.GridChar = gridChar;
            this.HullSize = hullSize;
            this.HullHeatlh = hullHealth;
        }

        // Member Methods
        public void Test()
        {
            
        }
        // Method for attacking

        // Method for taking damage

    }
}
