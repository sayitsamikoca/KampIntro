using System;
using System.Collections.Generic;
using System.Text;
using GameStoreManagementDemo.Abstract;

namespace GameStoreManagementDemo.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Discount { get; set; } // indirim 

    }
}
