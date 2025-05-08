using System.ComponentModel.DataAnnotations;

namespace MyAPP.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "PhoneNumber is Required")]
        public string PhoneNumber { get; set; }
    }
}