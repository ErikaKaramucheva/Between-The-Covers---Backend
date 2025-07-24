using Microsoft.EntityFrameworkCore;

namespace Between_The_Covers___Backend.Entities
{
    public class BooksBlogDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public BooksBlogDbContext(DbContextOptions<BooksBlogDbContext> options) : base(options) { }



    }
}
