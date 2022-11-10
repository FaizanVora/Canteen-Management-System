using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel;

namespace Canteen_Management_System.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
#pragma warning disable CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        [Required]
#pragma warning disable CS8618 // Non-nullable property 'Password' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Password { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Password' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        [Required]
#pragma warning disable CS8618 // Non-nullable property 'Email' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Email { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Email' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

        public int Isadmin { get; set; } = 0;
        [Required]
        public int height { get; set; }
        [Required]
        public int wight { get; set; }



    }
}