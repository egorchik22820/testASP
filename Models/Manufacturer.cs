using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class Manufacturer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string? ManufacturerName { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
