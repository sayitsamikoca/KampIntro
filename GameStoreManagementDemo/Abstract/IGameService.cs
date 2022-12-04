using System;
using System.Collections.Generic;
using System.Text;
using GameStoreManagementDemo.Entities;

namespace GameStoreManagementDemo.Abstract
{
    public interface IGameService
    {
        void Sale(Game game , Gamer gamer, Campaign campaign);
        // Oyuncu,oyun ve kampanya parametresi alacak.(Kampanya entegrasyonu)
    }
}
