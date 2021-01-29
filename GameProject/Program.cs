using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GamerManager gamerManager = new GamerManager(new UserValidationService());
            var gamer= new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FristName = "Ayşenur",
                LastName = "Elmas",
                NationalityId = "12345678909",
                UserName = "ayse"
            };
            gamerManager.Add(gamer);

            
            GameManager gameManager = new GameManager();
            var game = new Game { Id = 1, GameName = "Forza Horizon 4", Platforms = "Xbox One, Microsoft Windows, Xbox X ve S Serisi", FirstReleaseDate = 2018, UnitPrice = 29.99 };
            gameManager.Add(game);


            CampaingManager campaingManager = new CampaingManager();
            var campaing = new Campaign { Id = 1, Name = "Yeni Gelen Özel %10 indirim", campaignDiscount = 10 };
            campaingManager.Add(campaing);

            SellService sellService = new CampaingSellManager();
            sellService.CampaingSell(game,gamer,campaing);
        }
    }
}
