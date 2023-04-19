using System.ComponentModel.DataAnnotations;

namespace ApiTestingWithEntity.Models
{
    public class BooksModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public string Author { get; set; }
    }
}
