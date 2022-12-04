using GameStoreManagementDemo.Abstract;
using GameStoreManagementDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreManagementDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi : " + campaign.Name + " " + "Id: " + campaign.Id);
        }

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine("Yeni Kampanya Eklendi : " + campaign.Name + " " + "Id: " + campaign.Id);
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi : " + campaign.Name + " " + "Id: " + campaign.Id); 
        }
    }
}
