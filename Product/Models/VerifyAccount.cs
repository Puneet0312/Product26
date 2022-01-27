using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class VerifyAccount
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
    }
}
