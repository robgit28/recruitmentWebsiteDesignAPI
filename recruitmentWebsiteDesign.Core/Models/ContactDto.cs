using System.ComponentModel.DataAnnotations;

namespace recruitmentWebsiteDesign.Core.Models
{
    public class ContactDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(13)]
        public string Telephone { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(500)]
        public string Message { get; set; }
    }
}
