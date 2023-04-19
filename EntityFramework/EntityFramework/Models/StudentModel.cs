using System.ComponentModel.DataAnnotations;

namespace EntityTest.Models
{
    public class StudentModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Dept { get; set; }
        
       [Required]
        public DateTime DOB { get; set; }
        public string Location { get; set; }

    }
}
