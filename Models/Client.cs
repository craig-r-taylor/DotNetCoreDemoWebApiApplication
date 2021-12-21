namespace DotNetCoreDemoWebApiApplication.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Client")]
    public class Client
    {
        [Key]
        [Required]
        // Not using much client data since it is not being used for anything except id 
        public int ClientId { get; set; }
    }
}
