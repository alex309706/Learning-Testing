using System.ComponentModel.DataAnnotations;

namespace ProjectToTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Age { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
