using GameStoreManagementDemo.Abstract;
using GameStoreManagementDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreManagementDemo.Concrete
{
    public class GameManager : IGameService
    {
        bool discountStatus = true; // İndirim uygulandımı ?

        public void Sale(Game game, Gamer gamer , Campaign campaign)
        {
            if (discountStatus)
            {
                var result = game.UnitPrice - campaign.Discount;

                Console.WriteLine("Satış Başarıyla Gerçekleştirildi.");
                Console.WriteLine($"Alıcı: {gamer.FirstName} " +
                    $"\nAlınan Oyun: {game.Name} \nFiyatı: {game.UnitPrice} \nİndirimli Fiyatı: {result}");
            }

            else
            {
                Console.WriteLine("Satış Başarıyla Gerçekleştirildi.");
                Console.WriteLine($"Alıcı: {gamer.FirstName} " +
                    $"\nAlınan Oyun: {game.Name} \nFiyatı: {game.UnitPrice} " +
                    $"\nİndirimli Fiyatı: -İNDİRİM UYGULANMADI-");
            }
        }
    }
}
