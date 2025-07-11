
using LibraryEFCoreProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryEFCoreProj.LibraryContext.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.Property(p => p.Name).IsRequired().HasColumnType("VARCHAR").HasMaxLength(255);
            builder.HasData(
                new Author { AuthorId = 1, Name = "J.K. Rowling" },
                new Author { AuthorId = 2, Name = "J.R.R. Tolkien" },
                new Author { AuthorId = 3, Name = "George Orwell" },
                new Author { AuthorId = 4, Name = "Agatha Christie" },
                new Author { AuthorId = 5, Name = "Jane Austen" },
                new Author { AuthorId = 6, Name = "Stephen King" },
                new Author { AuthorId = 7, Name = "Isaac Asimov" },
                new Author { AuthorId = 8, Name = "Virginia Woolf" },
                new Author { AuthorId = 9, Name = "Ernest Hemingway" },
                new Author { AuthorId = 10, Name = "Toni Morrison" },
                new Author { AuthorId = 11, Name = "Charles Dickens" },
                new Author { AuthorId = 12, Name = "Emily Brontë" },
                new Author { AuthorId = 13, Name = "F. Scott Fitzgerald" },
                new Author { AuthorId = 14, Name = "Gabriel García Márquez" },
                new Author { AuthorId = 15, Name = "Mark Twain" },
                new Author { AuthorId = 16, Name = "Mary Shelley" },
                new Author { AuthorId = 17, Name = "Ray Bradbury" },
                new Author { AuthorId = 18, Name = "Leo Tolstoy" },
                new Author { AuthorId = 19, Name = "Harper Lee" },
                new Author { AuthorId = 20, Name = "Salman Rushdie" }
                );
        }
    }
}

