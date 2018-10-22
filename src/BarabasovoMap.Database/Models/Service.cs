using System;
using System.Collections.Generic;

namespace BarabasovoMap.Database.Models
{
    public class Service
    {
        public Guid Id { get; set; }

        public decimal MinPrice { get; set; }

        public decimal MaxPrice { get; set; }

        public string Info { get; set; }

        public virtual ICollection<PointService> PointServices { get; set; }
    }
}