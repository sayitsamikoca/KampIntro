using GameStoreManagementDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreManagementDemo.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckRealIfPerson(Gamer gamer);
    }
}
