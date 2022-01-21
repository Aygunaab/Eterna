using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string filterName { get; set; }
        public ICollection<Portfolio> portfolios { get; set; }
    }
}
