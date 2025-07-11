
namespace LibraryEFCoreProj.Models
{
    public class Borrower
    {
        public int BorrowerId { get; set; }
        public string Name { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }
    }
}
