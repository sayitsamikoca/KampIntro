using GameStoreManagementDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreManagementDemo.Abstract
{
    public interface ICampaignService
    {
        void NewCampaign(Campaign campaign); 
        void DeleteCampaign(Campaign campaign); 
        void UpdateCampaign(Campaign campaign); 
    }
}
