using DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    class Ware : Base
    {
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Volume { get; set; }
    }
}
