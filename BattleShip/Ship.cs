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
    public abstract class Ship
    {
        // Member Variables
        public string Type { get; set; }
        public char GridChar { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; }
        public bool isSunk { get { return Hits >= Width; } }
        
            
        // Constructor
        

        // Member Methods
        
        // Method for attacking

        // Method for taking damage

    }
}
