using System;

namespace BarabasovoMap.Database.Models
{
    public class PointService
    {
        public Guid Id { get; set; }

        public Guid PointId { get; set; }
        public virtual Point Point { get; set; }

        public Guid ServiceId { get; set; }
        public virtual Service Service { get; set; }
    }
}