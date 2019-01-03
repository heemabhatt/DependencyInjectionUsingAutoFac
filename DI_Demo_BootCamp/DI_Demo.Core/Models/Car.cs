using System.ComponentModel.DataAnnotations;

namespace DI_Demo_BootCamp.Core.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Car Name is required.")]
        public string Name { get; set; }
    }
}
