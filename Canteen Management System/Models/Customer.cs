using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel;

namespace Canteen_Management_System.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }

        public int Isadmin { get; set; } = 0;
        [Required]
        public int height { get; set; }
        [Required]
        public int wight { get; set; }



    }
}