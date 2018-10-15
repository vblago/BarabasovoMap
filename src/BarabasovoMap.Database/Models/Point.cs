using System;
using System.Collections.Generic;

namespace BarabasovoMap.Database.Models
{
    public class Point
    {
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }

        public Guid LocationId { get; set; }
        public virtual Location Location { get; set; }

        public virtual ICollection<Seller> Sellers { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}