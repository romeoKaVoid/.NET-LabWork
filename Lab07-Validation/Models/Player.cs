using System.ComponentModel.DataAnnotations;

namespace LabMVC.Models
{
    public class Player
    {
        [Required]
        public string Name { get; set; } = "";

        [Required]
        [Range(1, 99)]
        public int Age { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Country { get; set; } = "";
    }
}