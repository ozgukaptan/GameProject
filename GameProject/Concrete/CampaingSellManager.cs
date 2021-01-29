using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class CampaingSellManager :SellService
    {
        public override void CampaingSell(Game game, Gamer gamer,Campaign campaign)
        {
            double price = game.UnitPrice -(game.UnitPrice * campaign.campaignDiscount/100);
            Console.WriteLine("{0} Oyunu {1} tarafıdan kampanyalı fiyatı {2} TL'ye satın alındı.", game.GameName, gamer.UserName, price);
        }
    }
}
