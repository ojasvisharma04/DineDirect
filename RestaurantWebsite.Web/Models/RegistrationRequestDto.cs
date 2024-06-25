﻿using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Web.Models
{
    public class RegistrationRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string? RoleName { get; set; }



    }
}
