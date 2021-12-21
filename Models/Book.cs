namespace DotNetCoreDemoWebApiApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Book")]
    public class Book : Product
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public String Title { get; set; }

        [Required]
        public String Isbn { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}
