using System;

namespace BarabasovoMap.Database.Models
{
    public class Seller : User
    {
        public string Info { get; set; }

        public Guid PointId { get; set; }
        public virtual Point Point { get; set; }
    }
}