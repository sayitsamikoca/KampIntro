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
        FakeMernisServiceAdapter _fakeMernisService;

        public GamerManager(FakeMernisServiceAdapter fakeMernisService)
        {
            _fakeMernisService = fakeMernisService;

            // Ben bir kimlik doğrulama servisi kulanıyorum!
            // Bu sınıf artık bağımlı
        }

        public void Register(Gamer gamer)
        {
            if (_fakeMernisService.CheckRealIfPerson(gamer))
            {
                Console.WriteLine("Kayıt Başarılı");
            }
            else
            {
                Console.WriteLine("\nDoğrulama Başarısız!!!\n");
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
