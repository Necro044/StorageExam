using DAL.Entities.Abstract;
using DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    class Storage : Base
    {
        public Storage()
        {
            Wares = new HashSet<Ware>();
        }
        public StorageType Type { get; set; }
        public string Discription { get; set; }
        public int MaxVolume { get; set; }
        public virtual ICollection<Ware> Wares { get; set; }
    }
}
