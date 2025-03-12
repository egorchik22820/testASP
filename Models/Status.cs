using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class Status
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string? StatusName { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
