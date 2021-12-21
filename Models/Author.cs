namespace DotNetCoreDemoWebApiApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Author")]
    public class Author
    {
        [Key]
        [Required]
        public int AuthorId { get; set; }

#nullable enable
        [StringLength(50)]
        public String? FirstName { get; set; }

        [StringLength(50)]
        public String? MiddleNames { get; set; }

        [StringLength(50)]
        public String? LastName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
