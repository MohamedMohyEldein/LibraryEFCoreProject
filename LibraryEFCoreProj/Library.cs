
using LibraryEFCoreProj.LibraryContext;
using LibraryEFCoreProj.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryEFCoreProj
{
    public static class Library
    {
        public static void MainMenu(AppDBContext context)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("|________________________Select an option________________________|\n\n");
                Console.WriteLine("• 1-Add a book\n" +
                                  "• 2-List all books\n" +
                                  "• 3-Update a book\n" +
                                  "• 4-Delete a book\n" +
                                  "• 5-Borrow a book\n" +
                                  "• 6-Return a book\n" +
                                  "• 7-List overdue books\n" +
                                  "• 8-Exit\n");


                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                {
                    AddBook(context);
                    break;
                }
                else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                {
                    ListAllBooks(context, true, 1);
                    break;
                }
                else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                {
                    UpdateBook(context);
                    break;
                }
                else if (key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4)
                {
                    DeleteBook(context);
                    break;
                }
                else if (key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.NumPad5)
                {
                    BorrowBook(context);
                    break;
                }
                else if (key.Key == ConsoleKey.D6 || key.Key == ConsoleKey.NumPad6)
                {
                    ReturnBook(context);
                    break;
                }
                else if (key.Key == ConsoleKey.D7 || key.Key == ConsoleKey.NumPad7)
                {
                    ListOverdueBooks(context, true, 1);
                    break;
                }
                else if (key.Key == ConsoleKey.D8 || key.Key == ConsoleKey.NumPad8)
                {
                    break;
                }


            }
        }

        public static void ListOverdueBooks(AppDBContext context, bool FirstCall, int page = 1)
        {
            int pageSize = 10;

            var overDueBooks = context.Borrowings.AsNoTracking().Where(q => q.ReturnDate == null && q.BorrowDate < DateTime.Now.AddDays(-14));

            int totalPages = (int)Math.Ceiling((double)overDueBooks.Count() / pageSize);

            if (FirstCall)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nListing all overdue books....");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                FirstCall = false;
            }

            var query = context.Books.Join(overDueBooks, q1 => q1.BookId, q2 => q2.BookId, (q1, q2) => q1).Skip((page - 1) * pageSize).Take(pageSize);
            Console.Clear();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 1; i <= totalPages; i++)
            {
                if (i == page) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"{i} ");

            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\nPrevious page <-          Next page ->           Quit 'Q or q'");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                var k = Console.ReadKey();
                if (k.Key == ConsoleKey.Q)
                {
                    MainMenu(context);
                    break;
                }
                else if (k.Key == ConsoleKey.LeftArrow && page > 1)
                {
                    ListOverdueBooks(context, false, page - 1);
                    break;
                }
                else if (k.Key == ConsoleKey.RightArrow && page < totalPages)
                {
                    ListOverdueBooks(context, false, page + 1);
                    break;
                }

            }
        }

        public static void AddBook(AppDBContext context)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nAdding book....");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("|________________________Enter book title________________________|");
            var title = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("|________________________Enter publication year________________________|");

            int publicationYear;

            while (true)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out publicationYear);
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("___________!!!Enter a valid number!!!___________");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.Clear();
            Console.WriteLine("|________________________Enter author name________________________|");

            int authorId;

            string authorName = Console.ReadLine();
            try
            {
                var query = context.Authors.Single(q => q.Name == authorName);
                authorId = query.AuthorId;
            }
            catch
            {

                var author = new Author
                {
                    Name = authorName,
                };
                context.Add(author);
                context.SaveChanges();
                authorId = author.AuthorId;
            }
            var book = new Book
            {
                Title = title,
                AuthorId = authorId,
                PublicationYear = publicationYear
            };
            context.Books.Add(book);
            context.SaveChanges();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("☺The book has been added successfully☺");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.White;
            MainMenu(context);
        }
        public static void ReturnBook(AppDBContext context)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nReturning book....");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("|________________________Enter borrowing id________________________|");

            int borrowingId;
            while (true)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out borrowingId);
                    var query = context.Borrowings.Single(q => q.BorrowingId == borrowingId && q.ReturnDate == null);
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("___________!!!Borrowing id not found!!!___________");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            var result = context.Borrowings.Single(q => q.BorrowingId == borrowingId);
            result.ReturnDate = DateTime.UtcNow;
            context.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("☺The book has been returned successfully☺");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(result.Book);
            Thread.Sleep(3000);
            MainMenu(context);


        }

        public static void BorrowBook(AppDBContext context)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nBorrowing book....");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("|________________________Enter your full name________________________|");

            var borrower = new Borrower
            {
                Name = Console.ReadLine()
            };
            context.Borrowers.Add(borrower);
            context.SaveChanges();
            int borrowerId = borrower.BorrowerId;

            Console.Clear();
            Console.WriteLine("|________________________Enter book name you want to borrow________________________|");

            int bookId;

            while (true)
            {
                var bookTitle = Console.ReadLine();
                try
                {
                    var book = context.Books.Single(q => q.Title == bookTitle);
                    bookId = book.BookId;
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("___________!!!Book name not found!!!___________");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.Clear();
            Console.WriteLine("|________________________Enter the book return date like [2025-2-25]________________________|");

            DateTime returnDate;
            while (true)
            {
                try
                {
                    DateTime.TryParse(Console.ReadLine(), out returnDate);
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("___________!!!Please enter a valid date!!!___________");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            var borrowing = new Borrowing
            {
                BookId = bookId,
                BorrowDate = DateTime.UtcNow,
                ReturnDate = returnDate,
                BorrowerId = borrowerId
            };
            context.Borrowings.Add(borrowing);
            context.SaveChanges();
            MainMenu(context);

        }

        public static void DeleteBook(AppDBContext context)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nDeleting book....");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("|________________________Enter book id________________________|");
            int id;
            while (true)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out id);
                    var query = context.Books.Single(q => q.BookId == id);
                    context.Books.Remove(query);
                    context.SaveChanges();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("☺The book has been deleted successfully☺");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.White;
                    MainMenu(context);
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("___________!!!Book id not found!!!___________");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }

        }

        public static void UpdateBook(AppDBContext context)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nUpdating Book....");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("|________________________Enter book id________________________|");
            int id;
            while (true)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out id);
                    var query = context.Books.Single(q => q.BookId == id);
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("___________!!!Book id not found!!!___________");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
            Console.Clear();
            Console.WriteLine("|________________________Enter new book title________________________|");
            string title = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("|________________________Enter new publication year________________________|");
            int publicationYear;

            while (true)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out publicationYear);
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("___________!!!Enter a valid number!!!___________");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.Clear();
            Console.WriteLine("|________________________Enter author name________________________|");

            while (true)
            {
                try
                {
                    string authorName = Console.ReadLine();
                    var query = context.Authors.Single(q => q.Name == authorName);
                    int authorId = query.AuthorId;

                    var result = context.Books.Single(q => q.BookId == id);
                    result.Title = title;
                    result.PublicationYear = publicationYear;
                    result.AuthorId = authorId;

                    context.Books.Update(result);
                    context.SaveChanges();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("☺The book has been updated successfully☺");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.White;
                    MainMenu(context);
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("___________!!!Author name not found!!!___________");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }


        }

        public static void ListAllBooks(AppDBContext context, bool FirstCall, int page = 1)
        {
            int pageSize = 10;
            var query = context.Books.AsNoTracking().Skip((page - 1) * pageSize).Take(pageSize);

            if (FirstCall)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nListing all books....");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                FirstCall = false;
            }

            Console.Clear();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            int totalPages = (int)Math.Ceiling((double)context.Books.AsNoTracking().Count() / pageSize);
            Console.WriteLine();
            for (int i = 1; i <= totalPages; i++)
            {
                if (i == page) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"{i} ");

            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\nPrevious page <-          Next page ->           Quit 'Q or q'");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                var k = Console.ReadKey();
                if (k.Key == ConsoleKey.Q)
                {
                    MainMenu(context);
                    break;
                }
                else if (k.Key == ConsoleKey.LeftArrow && page > 1)
                {
                    ListAllBooks(context, false, page - 1);
                    break;
                }
                else if (k.Key == ConsoleKey.RightArrow && page < totalPages)
                {
                    ListAllBooks(context, false, page + 1);
                    break;
                }
            }
        }

    }
}
