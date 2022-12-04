using System;
using System.Collections.Generic;
using System.Text;
using GameStoreManagementDemo.Entities;

namespace GameStoreManagementDemo.Abstract
{
    public interface IGamerService
    {
        void Register(Gamer gamer); 
        void UpdateInformation(Gamer gamer); 
        void Unregister(Gamer gamer); 

    }
}
