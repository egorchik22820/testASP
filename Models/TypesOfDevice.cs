using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class TypesOfDevice
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string? TypeName { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
