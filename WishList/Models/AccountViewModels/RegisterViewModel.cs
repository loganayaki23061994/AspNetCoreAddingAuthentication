using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength (100)]
        [MinLength (8)]
        [DataType (DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare (nameof(Password), ErrorMessage ="Passwords Do not Match")]
        public string ConfirmPassword { get; set; }
    }
}
