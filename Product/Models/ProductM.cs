using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class ProductM
    {
        [Key]
        public int Id { get; set; }
       
        [Required(ErrorMessage ="*")]
        public string Title { get; set; }

        [Required(ErrorMessage = "*")]
        public string Quantity { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public int CatId { get; set; }

        [NotMapped]
        public string Category { get; set; }

    }
}
