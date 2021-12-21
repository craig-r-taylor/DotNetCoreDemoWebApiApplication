namespace DotNetCoreDemoWebApiApplication.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        [Key]
        [Required]
        public int ShoppingCartId { get; set; }

        //[ForeignKey("ProductId")]
        public ICollection<Product> Products { get; set; }

        public Client Client { get; set; }
    }
}
