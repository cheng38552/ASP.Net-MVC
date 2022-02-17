using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Gamer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int TeamId { get; set; }
    }
}