using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class CampaingManager : ICampaign
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
