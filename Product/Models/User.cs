using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "*", MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "*", MinimumLength = 2)]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "*", MinimumLength = 2)]
        public string Password { get; set; }
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "*", MinimumLength = 2)]
        public bool IsActive { get; set; }
        public string profile_image { get; set; }
        public Boolean isverified { get; set; }
        public VerifyAccount VerifyAccount { get; set; }
    }
}
