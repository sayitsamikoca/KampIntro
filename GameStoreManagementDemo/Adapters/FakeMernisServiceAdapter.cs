using GameStoreManagementDemo.Abstract;
using GameStoreManagementDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreManagementDemo.Adapters
{
    public class FakeMernisServiceAdapter : IGamerCheckService
    {
        public bool CheckRealIfPerson(Gamer gamer)
        {
            if (gamer.IdentificationNumber == "12345" && 
                gamer.FirstName == "Mark" && 
                gamer.YearOfBirth == new DateTime(1900,01,01))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
