using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Type = "Destroyer";
            Width = 2;
            GridChar = 'D';

        }
    }
}
