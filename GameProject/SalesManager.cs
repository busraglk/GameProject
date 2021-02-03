using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Sales(Games games, Gamer gamer, Campaign campaign)
        {
            int indirimliFiyat = games.GamePrice - campaign.CampaignAmount;
            Console.WriteLine(gamer.FirstName + " " + "oyuncu" + " " + games.GameName + " " + "oyununu" + " " + campaign.CampaignName + " " + "kampanyası ile " + indirimliFiyat + " " + "TL'den aldı.");
        }
    }
}
