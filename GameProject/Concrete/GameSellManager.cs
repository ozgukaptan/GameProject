using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameSellManager :SellService
    {
        public override void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine("{0} Oyunu {1} tarafıdan  {2} TL'ye satın alındı.", game.GameName, gamer.FristName,game.UnitPrice);
        }
    }
}
