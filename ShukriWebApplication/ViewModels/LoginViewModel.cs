﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShukriWebApplication.ViewModels
{
    public class LoginViewModel
    {
        [Required]
  
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
