﻿using System.ComponentModel.DataAnnotations;

namespace MovieApi.Dtos
{
    public class RegisterRequest
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        
    }
}
