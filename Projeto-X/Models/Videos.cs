using System.ComponentModel.DataAnnotations;

namespace Projeto_X.Models
{
    public class Videos
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required, MaxLength(500), MinLength(30)]
        public string Description { get; set; }
        [Required]
        public Byte[] Data { get; set; }
        [Required, MaxLength(30)]
        public string Extension { get; set; }
    }
}
