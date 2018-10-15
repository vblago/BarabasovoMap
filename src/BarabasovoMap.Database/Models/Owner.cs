using System.Collections.Generic;

namespace BarabasovoMap.Database.Models
{
    public class Owner : User
    {
        public string Info { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}