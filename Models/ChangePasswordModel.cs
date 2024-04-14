﻿using System.ComponentModel.DataAnnotations;

namespace JWTTokenAPI.Models
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }  
        
        [Required(ErrorMessage = "Current Password is required")]
        public string CurrentPassword { get; set; } 
        
        [Required(ErrorMessage = "Password is required")]
        public string NewPassword { get; set; }
    }
}
