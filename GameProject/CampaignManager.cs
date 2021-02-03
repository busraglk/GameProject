using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya: " + campaign.CampaignName + " Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya: " + campaign.CampaignName + " Silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya: " + campaign.CampaignName + " Güncellendi.");
        }
    }
 }

