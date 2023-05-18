using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nimap_Infotech_Project.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(20)]
        public string? ProductName { get; set; }
        public int CategoryId { get; set; }
        [NotMapped]
        public string? CategoryName { get; set; }
    }
}
