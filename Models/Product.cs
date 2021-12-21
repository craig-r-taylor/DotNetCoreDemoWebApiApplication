namespace DotNetCoreDemoWebApiApplication.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Product")]
    public abstract class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 1)]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public double Price { get; set; }
    }
}