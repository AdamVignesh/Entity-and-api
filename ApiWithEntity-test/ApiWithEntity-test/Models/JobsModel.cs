using System.ComponentModel.DataAnnotations;

namespace ApiWithEntity_test.Models
{
    public class JobsModel
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }


    }
}
