using LibraryEFCoreProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LibraryEFCoreProj.LibraryContext
{
    public class AppDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var configuration = new ConfigurationBuilder().AddJsonFile("D:\\C# Programs\\LibraryEFCoreSol\\LibraryEFCoreProj\\LibraryContext\\AppSettings.json").Build();
            var connectionString = configuration.GetSection("ConnectionString").Value;
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);
        }
    }
}
