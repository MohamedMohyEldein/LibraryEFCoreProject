
using LibraryEFCoreProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryEFCoreProj.LibraryContext.Configuration
{
    public class BorrowingConfiguration : IEntityTypeConfiguration<Borrowing>
    {
        public void Configure(EntityTypeBuilder<Borrowing> builder)
        {
            builder.ToTable("Borrowings");

            builder.HasData(
                new Borrowing { BorrowingId = 1, BookId = 1, BorrowerId = 1, BorrowDate = new DateTime(2025, 6, 1), ReturnDate = null },
                new Borrowing { BorrowingId = 2, BookId = 1, BorrowerId = 2, BorrowDate = new DateTime(2025, 6, 15), ReturnDate = new DateTime(2025, 6, 20) },
                new Borrowing { BorrowingId = 3, BookId = 2, BorrowerId = 3, BorrowDate = new DateTime(2025, 6, 10), ReturnDate = null },
                new Borrowing { BorrowingId = 4, BookId = 3, BorrowerId = 4, BorrowDate = new DateTime(2025, 6, 5), ReturnDate = new DateTime(2025, 6, 12) },
                new Borrowing { BorrowingId = 5, BookId = 4, BorrowerId = 5, BorrowDate = new DateTime(2025, 6, 2), ReturnDate = null },
                new Borrowing { BorrowingId = 6, BookId = 5, BorrowerId = 6, BorrowDate = new DateTime(2025, 6, 8), ReturnDate = new DateTime(2025, 6, 15) },
                new Borrowing { BorrowingId = 7, BookId = 6, BorrowerId = 7, BorrowDate = new DateTime(2025, 6, 3), ReturnDate = null },
                new Borrowing { BorrowingId = 8, BookId = 7, BorrowerId = 8, BorrowDate = new DateTime(2025, 6, 7), ReturnDate = new DateTime(2025, 6, 14) },
                new Borrowing { BorrowingId = 9, BookId = 8, BorrowerId = 9, BorrowDate = new DateTime(2025, 6, 4), ReturnDate = null },
                new Borrowing { BorrowingId = 10, BookId = 9, BorrowerId = 10, BorrowDate = new DateTime(2025, 6, 6), ReturnDate = new DateTime(2025, 6, 13) },
                new Borrowing { BorrowingId = 11, BookId = 10, BorrowerId = 11, BorrowDate = new DateTime(2025, 6, 9), ReturnDate = null },
                new Borrowing { BorrowingId = 12, BookId = 11, BorrowerId = 12, BorrowDate = new DateTime(2025, 6, 11), ReturnDate = new DateTime(2025, 6, 18) },
                new Borrowing { BorrowingId = 13, BookId = 12, BorrowerId = 13, BorrowDate = new DateTime(2025, 6, 12), ReturnDate = null },
                new Borrowing { BorrowingId = 14, BookId = 13, BorrowerId = 14, BorrowDate = new DateTime(2025, 6, 13), ReturnDate = new DateTime(2025, 6, 20) },
                new Borrowing { BorrowingId = 15, BookId = 14, BorrowerId = 15, BorrowDate = new DateTime(2025, 6, 14), ReturnDate = null },
                new Borrowing { BorrowingId = 16, BookId = 15, BorrowerId = 16, BorrowDate = new DateTime(2025, 6, 15), ReturnDate = new DateTime(2025, 6, 22) },
                new Borrowing { BorrowingId = 17, BookId = 16, BorrowerId = 17, BorrowDate = new DateTime(2025, 6, 16), ReturnDate = null },
                new Borrowing { BorrowingId = 18, BookId = 17, BorrowerId = 18, BorrowDate = new DateTime(2025, 6, 17), ReturnDate = new DateTime(2025, 6, 24) },
                new Borrowing { BorrowingId = 19, BookId = 18, BorrowerId = 19, BorrowDate = new DateTime(2025, 6, 18), ReturnDate = null },
                new Borrowing { BorrowingId = 20, BookId = 19, BorrowerId = 20, BorrowDate = new DateTime(2025, 6, 19), ReturnDate = new DateTime(2025, 6, 26) },
                new Borrowing { BorrowingId = 21, BookId = 20, BorrowerId = 1, BorrowDate = new DateTime(2025, 6, 20), ReturnDate = null },
                new Borrowing { BorrowingId = 22, BookId = 21, BorrowerId = 2, BorrowDate = new DateTime(2025, 6, 21), ReturnDate = new DateTime(2025, 6, 28) },
                new Borrowing { BorrowingId = 23, BookId = 22, BorrowerId = 3, BorrowDate = new DateTime(2025, 6, 22), ReturnDate = null },
                new Borrowing { BorrowingId = 24, BookId = 23, BorrowerId = 4, BorrowDate = new DateTime(2025, 6, 23), ReturnDate = new DateTime(2025, 6, 30) },
                new Borrowing { BorrowingId = 25, BookId = 24, BorrowerId = 5, BorrowDate = new DateTime(2025, 6, 24), ReturnDate = null },
                new Borrowing { BorrowingId = 26, BookId = 25, BorrowerId = 6, BorrowDate = new DateTime(2025, 6, 25), ReturnDate = new DateTime(2025, 7, 2) },
                new Borrowing { BorrowingId = 27, BookId = 26, BorrowerId = 7, BorrowDate = new DateTime(2025, 6, 26), ReturnDate = null },
                new Borrowing { BorrowingId = 28, BookId = 27, BorrowerId = 8, BorrowDate = new DateTime(2025, 6, 27), ReturnDate = new DateTime(2025, 7, 4) },
                new Borrowing { BorrowingId = 29, BookId = 28, BorrowerId = 9, BorrowDate = new DateTime(2025, 6, 28), ReturnDate = null },
                new Borrowing { BorrowingId = 30, BookId = 29, BorrowerId = 10, BorrowDate = new DateTime(2025, 6, 29), ReturnDate = new DateTime(2025, 7, 6) },
                new Borrowing { BorrowingId = 31, BookId = 30, BorrowerId = 11, BorrowDate = new DateTime(2025, 6, 30), ReturnDate = null },
                new Borrowing { BorrowingId = 32, BookId = 31, BorrowerId = 12, BorrowDate = new DateTime(2025, 7, 1), ReturnDate = new DateTime(2025, 7, 8) },
                new Borrowing { BorrowingId = 33, BookId = 32, BorrowerId = 13, BorrowDate = new DateTime(2025, 7, 2), ReturnDate = null },
                new Borrowing { BorrowingId = 34, BookId = 33, BorrowerId = 14, BorrowDate = new DateTime(2025, 7, 3), ReturnDate = new DateTime(2025, 7, 10) },
                new Borrowing { BorrowingId = 35, BookId = 34, BorrowerId = 15, BorrowDate = new DateTime(2025, 7, 4), ReturnDate = null },
                new Borrowing { BorrowingId = 36, BookId = 35, BorrowerId = 16, BorrowDate = new DateTime(2025, 7, 5), ReturnDate = new DateTime(2025, 7, 12) },
                new Borrowing { BorrowingId = 37, BookId = 36, BorrowerId = 17, BorrowDate = new DateTime(2025, 7, 6), ReturnDate = null },
                new Borrowing { BorrowingId = 38, BookId = 37, BorrowerId = 18, BorrowDate = new DateTime(2025, 7, 7), ReturnDate = new DateTime(2025, 7, 14) },
                new Borrowing { BorrowingId = 39, BookId = 38, BorrowerId = 19, BorrowDate = new DateTime(2025, 7, 8), ReturnDate = null },
                new Borrowing { BorrowingId = 40, BookId = 39, BorrowerId = 20, BorrowDate = new DateTime(2025, 7, 9), ReturnDate = new DateTime(2025, 7, 16) },
                new Borrowing { BorrowingId = 41, BookId = 40, BorrowerId = 1, BorrowDate = new DateTime(2025, 7, 10), ReturnDate = null },
                new Borrowing { BorrowingId = 42, BookId = 41, BorrowerId = 2, BorrowDate = new DateTime(2025, 7, 11), ReturnDate = new DateTime(2025, 7, 18) },
                new Borrowing { BorrowingId = 43, BookId = 42, BorrowerId = 3, BorrowDate = new DateTime(2025, 7, 12), ReturnDate = null },
                new Borrowing { BorrowingId = 44, BookId = 43, BorrowerId = 4, BorrowDate = new DateTime(2025, 7, 13), ReturnDate = new DateTime(2025, 7, 20) },
                new Borrowing { BorrowingId = 45, BookId = 44, BorrowerId = 5, BorrowDate = new DateTime(2025, 7, 14), ReturnDate = null },
                new Borrowing { BorrowingId = 46, BookId = 45, BorrowerId = 6, BorrowDate = new DateTime(2025, 7, 15), ReturnDate = new DateTime(2025, 7, 22) },
                new Borrowing { BorrowingId = 47, BookId = 46, BorrowerId = 7, BorrowDate = new DateTime(2025, 7, 16), ReturnDate = null },
                new Borrowing { BorrowingId = 48, BookId = 47, BorrowerId = 8, BorrowDate = new DateTime(2025, 7, 17), ReturnDate = new DateTime(2025, 7, 24) },
                new Borrowing { BorrowingId = 49, BookId = 48, BorrowerId = 9, BorrowDate = new DateTime(2025, 7, 18), ReturnDate = null },
                new Borrowing { BorrowingId = 50, BookId = 49, BorrowerId = 10, BorrowDate = new DateTime(2025, 7, 19), ReturnDate = new DateTime(2025, 7, 26) },
                new Borrowing { BorrowingId = 51, BookId = 50, BorrowerId = 11, BorrowDate = new DateTime(2025, 7, 20), ReturnDate = null },
                new Borrowing { BorrowingId = 52, BookId = 51, BorrowerId = 12, BorrowDate = new DateTime(2025, 7, 21), ReturnDate = new DateTime(2025, 7, 28) },
                new Borrowing { BorrowingId = 53, BookId = 52, BorrowerId = 13, BorrowDate = new DateTime(2025, 7, 22), ReturnDate = null },
                new Borrowing { BorrowingId = 54, BookId = 53, BorrowerId = 14, BorrowDate = new DateTime(2025, 7, 23), ReturnDate = new DateTime(2025, 7, 30) },
                new Borrowing { BorrowingId = 55, BookId = 54, BorrowerId = 15, BorrowDate = new DateTime(2025, 7, 24), ReturnDate = null },
                new Borrowing { BorrowingId = 56, BookId = 55, BorrowerId = 16, BorrowDate = new DateTime(2025, 7, 25), ReturnDate = new DateTime(2025, 8, 1) },
                new Borrowing { BorrowingId = 57, BookId = 56, BorrowerId = 17, BorrowDate = new DateTime(2025, 7, 26), ReturnDate = null },
                new Borrowing { BorrowingId = 58, BookId = 57, BorrowerId = 18, BorrowDate = new DateTime(2025, 7, 27), ReturnDate = new DateTime(2025, 8, 3) },
                new Borrowing { BorrowingId = 59, BookId = 58, BorrowerId = 19, BorrowDate = new DateTime(2025, 7, 28), ReturnDate = null },
                new Borrowing { BorrowingId = 60, BookId = 59, BorrowerId = 20, BorrowDate = new DateTime(2025, 7, 29), ReturnDate = new DateTime(2025, 8, 5) }
            );
            
        }
    }
}
