
using LibraryEFCoreProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryEFCoreProj.LibraryContext.Configuration
{
    public class BorrowerConfiguration : IEntityTypeConfiguration<Borrower>
    {
        public void Configure(EntityTypeBuilder<Borrower> builder)
        {
            builder.ToTable("Borrowers");

            builder.Property(p => p.Name).IsRequired().HasColumnType("VARCHAR").HasMaxLength(255);
            builder.HasData(
                new Borrower { BorrowerId = 1, Name = "Alice Smith" },
                new Borrower { BorrowerId = 2, Name = "Bob Johnson" },
                new Borrower { BorrowerId = 3, Name = "Carol Williams" },
                new Borrower { BorrowerId = 4, Name = "David Brown" },
                new Borrower { BorrowerId = 5, Name = "Emma Davis" },
                new Borrower { BorrowerId = 6, Name = "Frank Wilson" },
                new Borrower { BorrowerId = 7, Name = "Grace Taylor" },
                new Borrower { BorrowerId = 8, Name = "Henry Moore" },
                new Borrower { BorrowerId = 9, Name = "Isabella Clark" },
                new Borrower { BorrowerId = 10, Name = "James Lee" },
                new Borrower { BorrowerId = 11, Name = "Katherine Adams" },
                new Borrower { BorrowerId = 12, Name = "Liam Harris" },
                new Borrower { BorrowerId = 13, Name = "Mia Lewis" },
                new Borrower { BorrowerId = 14, Name = "Noah Walker" },
                new Borrower { BorrowerId = 15, Name = "Olivia Young" },
                new Borrower { BorrowerId = 16, Name = "Peter Allen" },
                new Borrower { BorrowerId = 17, Name = "Quinn Baker" },
                new Borrower { BorrowerId = 18, Name = "Rachel Carter" },
                new Borrower { BorrowerId = 19, Name = "Samuel Evans" },
                new Borrower { BorrowerId = 20, Name = "Tara Green" }
            );

        }
    }
}
