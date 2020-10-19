using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    /// <summary>
    /// This is the parent class for ship child inheritance
    /// </summary>
    public class ShipYard // 
    {
        // Member Variables
        public List<Ship> player01Fleet;
        public List<Ship> player02Fleet;

        public string Type;
        public int HullSize;
        public int HullHeatlh;

        // Constructor // Builds the fleet
        public ShipYard()
        {
            player01Fleet = new List<Ship>
            {
                new Ship("Destroyer", 'D', 2, 2),
                new Ship("Submarine", 'S', 3, 3),
                new Ship("BattleShip",'B', 4, 4),
                new Ship("Aircraft Carrier", 'A',5, 5)

            };

            player02Fleet = new List<Ship>
            {
                new Ship("Destroyer", 'D', 2, 2),
                new Ship("Submarine", 'S', 3, 3),
                new Ship("BattleShip",'B', 4, 4),
                new Ship("Aircraft Carrier", 'A',5, 5)
            };
        }

        // Member Methods
        public void Test()
        {
            
        }
    }
}
