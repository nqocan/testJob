﻿using System.ComponentModel.DataAnnotations;

namespace MovieApi.Dtos
{
    public class LoginRequest
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
