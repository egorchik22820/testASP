using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }


        [Required]
        [StringLength(50)]
        public string? ProdName { get; set; }

        [Required]
        [StringLength(50)]
        public string? ProdLastName { get; set; }

        [Required]
        [StringLength(50)]
        public string? ProdDiscription { get; set; }

        [Required]
        public int ProdPrice { get; set; }

        public string? Images { get; set; }

        public Status? Status { get; set; }
        public TypesOfDevice? TypesOfDevice { get; set; }
        public Manufacturer? Manufacturer { get; set; }
    }
}
