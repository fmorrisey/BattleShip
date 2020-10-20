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
    class Player
    {
        // Member Variables

        public string Name { get; set; }
        public List<Ship> Fleet { get; set; }

        public Player(string name)
        {
            this.Name = name;
           Fleet = new List<Ship>
           {
               new Destroyer(),
               new Submarine(),
               new BattleShip(),
               new Crarrier()

           };
        }
    }
}
