
namespace LibraryEFCoreProj.Models
{
    public class Borrowing
    {
        public int BorrowingId { get; set; }
        public int BookId { get; set; }
        public int BorrowerId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Book Book { get; set; }
        public Borrower Borrower { get; set; }
    }
}
