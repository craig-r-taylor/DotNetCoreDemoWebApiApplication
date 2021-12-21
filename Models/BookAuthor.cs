using System.ComponentModel.DataAnnotations.Schema;

namespace PhdSolutionsDemoWebApiApplication.Models
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
