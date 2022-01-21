using Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Feature> Features { get; set; }
        public IEnumerable<Portfolio> Portfolios { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Client>Clients{ get; set; }

    }
}
