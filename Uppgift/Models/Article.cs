using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Display(Name = "Artikelnummer")]
        public string ArticleNum { get; set; }
        [Display(Name = "Artikelnamn")]
        public string Name { get; set; }
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }
        [Display(Name = "Kategori")]
        public string Category { get; set; }
        [Display(Name = "Pris")]
        public double Price { get; set; }
        [Display(Name = "Pris inkl moms")]
        public double PriceVAT
        {
            get
            {
                return Math.Round (Price/0.875, 3);
            }
                
        }
        
    }
}
