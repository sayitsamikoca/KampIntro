using System;
using GameStoreManagementDemo.Entities;
using GameStoreManagementDemo.Concrete;

namespace GameStoreManagementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                Id = 1,
                IdentificationNumber = "12345",
                FirstName = "Mark",
                LastName = "Zokker",
                YearOfBirth = new DateTime(1900,01,01)
            };

            Game game = new Game
            {
                Id = 1,
                CategoryName = "Savaş",
                Name = "Age of War",
                UnitPrice = 125
            };

            Campaign campaign = new Campaign
            {
                Id = 1,
                Name = "Yılbaşı İndirimi",
                Discount = 30
            };


            GameManager gameManager = new GameManager();
            gameManager.Sale(game, gamer, campaign);

            Console.WriteLine("\n -------------------------------------------------------------\n");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.NewCampaign(campaign);
            campaignManager.UpdateCampaign(campaign);
            campaignManager.DeleteCampaign(campaign);

            Console.WriteLine("\n -------------------------------------------------------------\n");


            GamerManager gamerManager = new GamerManager();
            gamerManager.Register(gamer);
            gamerManager.Unregister(gamer);
            gamerManager.UpdateInformation(gamer);

        }
    }
}
