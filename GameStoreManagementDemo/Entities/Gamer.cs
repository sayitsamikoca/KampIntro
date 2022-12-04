using System;
using System.Collections.Generic;
using System.Text;
using GameStoreManagementDemo.Abstract;

namespace GameStoreManagementDemo.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; } // TcNo
        public DateTime YearOfBirth { get; set; } // Doğum Yılı

    }
}
