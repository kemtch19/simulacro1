using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Simulacro1.Models
{
    public class Editorial
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Adress { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Status { get; set; }
        [JsonIgnore]
        public List<Editorial>? Editorials { get; set; }
    }
}