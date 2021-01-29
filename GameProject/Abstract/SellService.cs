using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public abstract class SellService
    {
        public virtual  void Sell(Game game, Gamer gamer) { }
        public virtual void CampaingSell(Game game, Gamer gamer,Campaign campaign) { }
    }
}
