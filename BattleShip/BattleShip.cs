using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class BattleShip : Ship
    {

        public BattleShip()
        {
            Type = "BattleShip";
            Width = 4;
            GridChar = 'B';
        }
    }
}
