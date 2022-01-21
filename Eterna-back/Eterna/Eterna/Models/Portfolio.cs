using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string image { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string Desc { get; set; }
        public List<PortfolioImage> portfolioImages { get; set; }
        public int CateId { get; set; }
        [ForeignKey("CateId")]
        public Category Category { get; set; }



    }
}
