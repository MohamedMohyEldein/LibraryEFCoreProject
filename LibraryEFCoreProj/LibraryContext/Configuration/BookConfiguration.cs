using LibraryEFCoreProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryEFCoreProj.LibraryContext.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");

            builder.Property(p => p.Title).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.HasOne(p => p.Author)
                .WithMany(p => p.Books)
                .HasForeignKey(p => p.AuthorId);

            builder.HasData(
                new Book { BookId = 1, Title = "Harry Potter and the Philosopher's Stone", PublicationYear = 1997, AuthorId = 1 },
                new Book { BookId = 2, Title = "Harry Potter and the Chamber of Secrets", PublicationYear = 1998, AuthorId = 1 },
                new Book { BookId = 3, Title = "Harry Potter and the Prisoner of Azkaban", PublicationYear = 1999, AuthorId = 1 },
                new Book { BookId = 4, Title = "Harry Potter and the Goblet of Fire", PublicationYear = 2000, AuthorId = 1 },
                new Book { BookId = 5, Title = "Harry Potter and the Order of the Phoenix", PublicationYear = 2003, AuthorId = 1 },
                new Book { BookId = 6, Title = "The Lord of the Rings: The Fellowship of the Ring", PublicationYear = 1954, AuthorId = 2 },
                new Book { BookId = 7, Title = "The Lord of the Rings: The Two Towers", PublicationYear = 1954, AuthorId = 2 },
                new Book { BookId = 8, Title = "The Lord of the Rings: The Return of the King", PublicationYear = 1955, AuthorId = 2 },
                new Book { BookId = 9, Title = "The Hobbit", PublicationYear = 1937, AuthorId = 2 },
                new Book { BookId = 10, Title = "The Silmarillion", PublicationYear = 1977, AuthorId = 2 },
                new Book { BookId = 11, Title = "1984", PublicationYear = 1949, AuthorId = 3 },
                new Book { BookId = 12, Title = "Animal Farm", PublicationYear = 1945, AuthorId = 3 },
                new Book { BookId = 13, Title = "Homage to Catalonia", PublicationYear = 1938, AuthorId = 3 },
                new Book { BookId = 14, Title = "Murder on the Orient Express", PublicationYear = 1934, AuthorId = 4 },
                new Book { BookId = 15, Title = "And Then There Were None", PublicationYear = 1939, AuthorId = 4 },
                new Book { BookId = 16, Title = "The Murder of Roger Ackroyd", PublicationYear = 1926, AuthorId = 4 },
                new Book { BookId = 17, Title = "Death on the Nile", PublicationYear = 1937, AuthorId = 4 },
                new Book { BookId = 18, Title = "Pride and Prejudice", PublicationYear = 1813, AuthorId = 5 },
                new Book { BookId = 19, Title = "Sense and Sensibility", PublicationYear = 1811, AuthorId = 5 },
                new Book { BookId = 20, Title = "Emma", PublicationYear = 1815, AuthorId = 5 },
                new Book { BookId = 21, Title = "Persuasion", PublicationYear = 1817, AuthorId = 5 },
                new Book { BookId = 22, Title = "The Shining", PublicationYear = 1977, AuthorId = 6 },
                new Book { BookId = 23, Title = "It", PublicationYear = 1986, AuthorId = 6 },
                new Book { BookId = 24, Title = "Carrie", PublicationYear = 1974, AuthorId = 6 },
                new Book { BookId = 25, Title = "Misery", PublicationYear = 1987, AuthorId = 6 },
                new Book { BookId = 26, Title = "Foundation", PublicationYear = 1951, AuthorId = 7 },
                new Book { BookId = 27, Title = "Foundation and Empire", PublicationYear = 1952, AuthorId = 7 },
                new Book { BookId = 28, Title = "Second Foundation", PublicationYear = 1953, AuthorId = 7 },
                new Book { BookId = 29, Title = "I, Robot", PublicationYear = 1950, AuthorId = 7 },
                new Book { BookId = 30, Title = "Mrs Dalloway", PublicationYear = 1925, AuthorId = 8 },
                new Book { BookId = 31, Title = "To the Lighthouse", PublicationYear = 1927, AuthorId = 8 },
                new Book { BookId = 32, Title = "Orlando", PublicationYear = 1928, AuthorId = 8 },
                new Book { BookId = 33, Title = "The Waves", PublicationYear = 1931, AuthorId = 8 },
                new Book { BookId = 34, Title = "The Old Man and the Sea", PublicationYear = 1952, AuthorId = 9 },
                new Book { BookId = 35, Title = "A Farewell to Arms", PublicationYear = 1929, AuthorId = 9 },
                new Book { BookId = 36, Title = "For Whom the Bell Tolls", PublicationYear = 1940, AuthorId = 9 },
                new Book { BookId = 37, Title = "Beloved", PublicationYear = 1987, AuthorId = 10 },
                new Book { BookId = 38, Title = "Song of Solomon", PublicationYear = 1977, AuthorId = 10 },
                new Book { BookId = 39, Title = "Jazz", PublicationYear = 1992, AuthorId = 10 },
                new Book { BookId = 40, Title = "A Tale of Two Cities", PublicationYear = 1859, AuthorId = 11 },
                new Book { BookId = 41, Title = "Great Expectations", PublicationYear = 1861, AuthorId = 11 },
                new Book { BookId = 42, Title = "Oliver Twist", PublicationYear = 1838, AuthorId = 11 },
                new Book { BookId = 43, Title = "Wuthering Heights", PublicationYear = 1847, AuthorId = 12 },
                new Book { BookId = 44, Title = "The Great Gatsby", PublicationYear = 1925, AuthorId = 13 },
                new Book { BookId = 45, Title = "Tender is the Night", PublicationYear = 1934, AuthorId = 13 },
                new Book { BookId = 46, Title = "One Hundred Years of Solitude", PublicationYear = 1967, AuthorId = 14 },
                new Book { BookId = 47, Title = "Love in the Time of Cholera", PublicationYear = 1985, AuthorId = 14 },
                new Book { BookId = 48, Title = "The Adventures of Tom Sawyer", PublicationYear = 1876, AuthorId = 15 },
                new Book { BookId = 49, Title = "Adventures of Huckleberry Finn", PublicationYear = 1884, AuthorId = 15 },
                new Book { BookId = 50, Title = "Frankenstein", PublicationYear = 1818, AuthorId = 16 },
                new Book { BookId = 51, Title = "The Last Man", PublicationYear = 1826, AuthorId = 16 },
                new Book { BookId = 52, Title = "Fahrenheit 451", PublicationYear = 1953, AuthorId = 17 },
                new Book { BookId = 53, Title = "The Martian Chronicles", PublicationYear = 1950, AuthorId = 17 },
                new Book { BookId = 54, Title = "War and Peace", PublicationYear = 1865, AuthorId = 18 },
                new Book { BookId = 55, Title = "Anna Karenina", PublicationYear = 1877, AuthorId = 18 },
                new Book { BookId = 56, Title = "To Kill a Mockingbird", PublicationYear = 1960, AuthorId = 19 },
                new Book { BookId = 57, Title = "Midnight’s Children", PublicationYear = 1981, AuthorId = 20 },
                new Book { BookId = 58, Title = "Satanic Verses", PublicationYear = 1988, AuthorId = 20 },
                new Book { BookId = 59, Title = "Harry Potter and the Deathly Hallows", PublicationYear = 2007, AuthorId = 1 },
                new Book { BookId = 60, Title = "The Casual Vacancy", PublicationYear = 2012, AuthorId = 1 },
                new Book { BookId = 61, Title = "Children of Hurin", PublicationYear = 2007, AuthorId = 2 },
                new Book { BookId = 62, Title = "Keep the Aspidistra Flying", PublicationYear = 1936, AuthorId = 3 },
                new Book { BookId = 63, Title = "The ABC Murders", PublicationYear = 1936, AuthorId = 4 },
                new Book { BookId = 64, Title = "Mansfield Park", PublicationYear = 1814, AuthorId = 5 },
                new Book { BookId = 65, Title = "Salem’s Lot", PublicationYear = 1975, AuthorId = 6 },
                new Book { BookId = 66, Title = "The Caves of Steel", PublicationYear = 1954, AuthorId = 7 },
                new Book { BookId = 67, Title = "A Room of One’s Own", PublicationYear = 1929, AuthorId = 8 },
                new Book { BookId = 68, Title = "The Sun Also Rises", PublicationYear = 1926, AuthorId = 9 },
                new Book { BookId = 69, Title = "Paradise", PublicationYear = 1997, AuthorId = 10 },
                new Book { BookId = 70, Title = "David Copperfield", PublicationYear = 1850, AuthorId = 11 },
                new Book { BookId = 71, Title = "Agnes Grey", PublicationYear = 1847, AuthorId = 12 },
                new Book { BookId = 72, Title = "This Side of Paradise", PublicationYear = 1920, AuthorId = 13 },
                new Book { BookId = 73, Title = "Chronicle of a Death Foretold", PublicationYear = 1981, AuthorId = 14 },
                new Book { BookId = 74, Title = "The Prince and the Pauper", PublicationYear = 1881, AuthorId = 15 },
                new Book { BookId = 75, Title = "Mathilda", PublicationYear = 1819, AuthorId = 16 },
                new Book { BookId = 76, Title = "Something Wicked This Way Comes", PublicationYear = 1962, AuthorId = 17 },
                new Book { BookId = 77, Title = "Resurrection", PublicationYear = 1899, AuthorId = 18 },
                new Book { BookId = 78, Title = "Go Set a Watchman", PublicationYear = 2015, AuthorId = 19 },
                new Book { BookId = 79, Title = "Shame", PublicationYear = 1983, AuthorId = 20 },
                new Book { BookId = 80, Title = "Harry Potter and the Half-Blood Prince", PublicationYear = 2005, AuthorId = 1 },
                new Book { BookId = 81, Title = "Beren and Lúthien", PublicationYear = 2017, AuthorId = 2 },
                new Book { BookId = 82, Title = "Coming Up for Air", PublicationYear = 1939, AuthorId = 3 },
                new Book { BookId = 83, Title = "Evil Under the Sun", PublicationYear = 1941, AuthorId = 4 },
                new Book { BookId = 84, Title = "Northanger Abbey", PublicationYear = 1817, AuthorId = 5 },
                new Book { BookId = 85, Title = "Doctor Sleep", PublicationYear = 2013, AuthorId = 6 },
                new Book { BookId = 86, Title = "The Naked Sun", PublicationYear = 1957, AuthorId = 7 },
                new Book { BookId = 87, Title = "Flush", PublicationYear = 1933, AuthorId = 8 },
                new Book { BookId = 88, Title = "Across the River and Into the Trees", PublicationYear = 1950, AuthorId = 9 },
                new Book { BookId = 89, Title = "Tar Baby", PublicationYear = 1981, AuthorId = 10 },
                new Book { BookId = 90, Title = "Bleak House", PublicationYear = 1853, AuthorId = 11 },
                new Book { BookId = 91, Title = "The Tenant of Wildfell Hall", PublicationYear = 1848, AuthorId = 12 },
                new Book { BookId = 92, Title = "The Beautiful and Damned", PublicationYear = 1922, AuthorId = 13 },
                new Book { BookId = 93, Title = "The Autumn of the Patriarch", PublicationYear = 1975, AuthorId = 14 },
                new Book { BookId = 94, Title = "A Connecticut Yankee in King Arthur’s Court", PublicationYear = 1889, AuthorId = 15 },
                new Book { BookId = 95, Title = "Valperga", PublicationYear = 1823, AuthorId = 16 },
                new Book { BookId = 96, Title = "Dandelion Wine", PublicationYear = 1957, AuthorId = 17 },
                new Book { BookId = 97, Title = "The Death of Ivan Ilyich", PublicationYear = 1886, AuthorId = 18 },
                new Book { BookId = 98, Title = "The Ground Beneath Her Feet", PublicationYear = 1999, AuthorId = 20 },
                new Book { BookId = 99, Title = "Hard Times", PublicationYear = 1854, AuthorId = 11 },
                new Book { BookId = 100, Title = "The Moor’s Last Sigh", PublicationYear = 1995, AuthorId = 20 }
            );
        }
    }
}
