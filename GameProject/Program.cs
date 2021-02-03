using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu Ekleme işlemi
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id=1,
                BirthOfYear =1985,
                FirstName="BARIŞ",
                LastName="DERİN",
                IdentityNumber=12345678910
            });

            Gamer gamer1 = new Gamer()
            {
                Id=1,
                FirstName="BARIŞ",
                LastName = "DERİN",
                IdentityNumber = 12345678910,
                BirthOfYear = 1985
            };
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Update(gamer1);


            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            gamerManager2.Add(new Gamer
            {
                Id = 1,
                BirthOfYear = 1985,
                FirstName = "AYŞE",
                LastName = "KORKUT",
                IdentityNumber = 34545678910
            });

            Console.WriteLine("\n**********");
            //Oyun ekleme işlemi
            GameManager gameManager = new GameManager();
            Games game1 = new Games
            {
                Id=1,
                GameName = "PBG",
                GamePrice = 100
            };
            
            Games game2 = new Games
            {
                Id = 2,
                GameName = "Survive",
                GamePrice = 120
            };

            Games game3 = new Games
            {
                Id = 3,
                GameName = "Mario",
                GamePrice = 150
            };

            gameManager.Add(game1);
            gameManager.Delete(game2);
            gameManager.Update(game3);

            Console.WriteLine("\n**********");

            //Kampanya Ekledik
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign
            {
                CampaignId=4,
                CampaignName= "Sepette %25 indirim",
                CampaignAmount = 25
            };
            campaignManager.Add(campaign1);

            Campaign campaign2 = new Campaign
            {
                CampaignId = 5,
                CampaignName = "Sepette %10 indirim",
                CampaignAmount = 10
            };

            campaignManager.Delete(campaign2);

            Console.WriteLine("\n**********");
            //Satış manager classına eklediğimiz oyun,oyuncu ve kampanyayı parametre ile gönderdik.
            //SalesManager classına gidip bakabilirsin.satış işlemi orda gerçekleşti.  
            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game1, gamer1, campaign1);


            Console.ReadLine();
        }
    }
}
