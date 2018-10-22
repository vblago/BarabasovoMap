using System;
using System.Collections.Generic;

namespace BarabasovoMap.Database.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Info { get; set; }

        public virtual ICollection<PointCategory> PointCategories { get; set; }
    }
}