using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    class FoodProduct : Ware
    {
        public DateTime DateOfManufacture { get; set; }
        public string StorageConditions { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
