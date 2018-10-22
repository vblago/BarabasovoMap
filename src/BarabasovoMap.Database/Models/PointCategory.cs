using System;

namespace BarabasovoMap.Database.Models
{
    public class PointCategory
    {
        public Guid Id { get; set; }

        public Guid PointId { get; set; }
        public virtual Point Point { get; set; }

        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}