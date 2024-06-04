using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Simulacro1.Models{
    public class Author{
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Nationality { get; set; }
        
        [Required]
        public string? Status { get; set; }

        [JsonIgnore]
        public List<Author>? Authors { get; set; }
    }
}