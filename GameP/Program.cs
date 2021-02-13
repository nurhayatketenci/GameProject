using GameProject;
using GameProject.Business.Concrete;
using GameProject.Entities;
using System;

namespace GameP
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamers gamer = new Gamers() { GamerId = 1, GamerName = "Nur", GamerSurname = "Hayat", BirthYear = 2000 };
            Campaign campaign = new Campaign() { CampaignId = 1, CampaignName = "february campaign ", CampaignDiscount = 50 };
            Game game = new Game() { GameName = "VALORANT", GamePrice = 100, GameType = "FPS", GameId = 1 };

            GamerManager gamerManager = new GamerManager(new ValidationManager());
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();

            gameManager.Add(game);
            campaignManager.Add(campaign);



            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer, game);
            salesManager.CampaignSales(gamer, game, campaign);
        }
    }
}
