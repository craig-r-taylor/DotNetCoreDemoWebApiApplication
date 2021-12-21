namespace DotNetCoreDemoWebApiApplication.Data
{
    using DotNetCoreDemoWebApiApplication.Models;
    using Microsoft.EntityFrameworkCore;

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Models.Book> Books { get; set; }

        public DbSet<ShoppingCart> ShoppingCart { get; set; }

        // Not needed for many to many as of .net core 5+
        //public DbSet<BookAuthor> BookAuthors { get; set; }

        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /**
             * The following code was needed for previous .net core but not for 5+
             * This is to handle a many to many relationship
             */

            /*           modelBuilder.Entity<BookAuthor>().HasKey(a => new { a.AuthorId, a.BookId });

                       modelBuilder.Entity<BookAuthor>()
                           .HasOne(a => a.Author)
                           .WithMany(b => b.Books)
                           .HasForeignKey(a => a.AuthorId);

                       modelBuilder.Entity<BookAuthor>()
                           .HasOne(a => a.Book)
                           .WithMany(b => b.Authors)
                           .HasForeignKey(a => a.BookId);
            */
        }
    }
}
