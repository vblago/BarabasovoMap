using System;

namespace BarabasovoMap.Database.Models
{
    public class Property
    {
        public Guid Id { get; set; }

        public string Info { get; set; }

        public Guid OwnerId { get; set; }
        public virtual Owner Owner { get; set; }

        public Guid PointId { get; set; }
        public virtual Point Point { get; set; }
    }
}