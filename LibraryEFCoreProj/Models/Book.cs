using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFCoreProj.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }

        public override string ToString()
        {
            return $".Book id = {BookId} .Book title = {Title} .Publication year = {PublicationYear} .Author id = {AuthorId}";
        }
    }
}
