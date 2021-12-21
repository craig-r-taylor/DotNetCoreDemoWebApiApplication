namespace DotNetCoreDemoWebApiApplication.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Order")]
    public class Order
    {
        [Key]
        [Required]
        public int OrderId { get; set; }

        public int ShoppingCartId { get; set; }
    }
}
