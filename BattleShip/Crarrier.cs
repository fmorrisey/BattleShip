using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Crarrier : Ship
    {
        public Crarrier()
        {
            Type = "Aircraft Carrier";
            Width = 5;
            GridChar = 'A';
        }
    }
}
