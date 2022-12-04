using GameStoreManagementDemo.Abstract;
using GameStoreManagementDemo.Entities;
using GameStoreManagementDemo.Adapters;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreManagementDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        FakeMernisServiceAdapter fakeMernisService = new FakeMernisServiceAdapter();
        public void Register(Gamer gamer)
        {
            if (fakeMernisService.CheckRealIfPerson(gamer))
            {
                Console.WriteLine("Kayıt Başarılı");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız!!!");
            }
        }

        public void Unregister(Gamer gamer)
        {
            Console.WriteLine("Kayıt başarıyla silindi : " + gamer.FirstName);
        }

        public void UpdateInformation(Gamer gamer)
        {
            Console.WriteLine("Bilgiler başarıyla güncellendi: " + gamer.FirstName);
        }
    }
}
