using GameStoreManagementDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreManagementDemo.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
