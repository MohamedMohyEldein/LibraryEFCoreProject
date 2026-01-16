# 📚 Library Management System (EF Core)

A console-based Library Management System built with C#, Entity Framework Core, and LINQ.
The application demonstrates CRUD operations, relationships, pagination, and basic business logic using EF Core in a clean, structured way.

🚀 Features

📖 Add, update, delete, and list books

✍️ Manage authors automatically

👤 Borrow and return books

⏰ Track overdue books (over 14 days)

📄 Paginated listing for books and overdue records

🧠 Uses LINQ for querying and filtering data

⚡ Optimized read operations with AsNoTracking

🛠️ Technologies Used

C#

.NET

Entity Framework Core

LINQ

Console Application

No external frameworks or UI libraries were used.
All data access logic is implemented using EF Core and LINQ.

🗂️ Project Structure
LibraryEFCoreProj
│
├── Models
│   ├── Book.cs
│   ├── Author.cs
│   ├── Borrower.cs
│   └── Borrowing.cs
│
├── LibraryContext
│   └── AppDBContext.cs
│
├── Library.cs
│   └── Main application logic & menu
│
└── Program.cs

📊 Database Design

The project uses relational entities with proper relationships:

Book → belongs to an Author

Borrowing → links Book and Borrower

Borrower → can have multiple borrowings

EF Core handles:

Relationships

Foreign keys

Data persistence

📌 Key EF Core & LINQ Concepts Demonstrated

DbContext and DbSet

CRUD operations

LINQ queries (Where, Single, First, Skip, Take)

Pagination

Include() for navigation properties

AsNoTracking() for performance

Entity state tracking and updates

▶️ How to Run

Clone the repository:

git clone https://github.com/your-username/LibraryEFCoreProj.git


Open the solution in Visual Studio

Update the database connection string in AppDBContext

Apply migrations:

Update-Database


Run the project and use the interactive console menu

📷 Sample Menu
1- Add a book
2- List all books
3- Update a book
4- Delete a book
5- Borrow a book
6- Return a book
7- List overdue books
8- Exit

🎯 Purpose of This Project

This project was built to:

Practice Entity Framework Core

Strengthen LINQ querying skills

Understand database relationships

Build a structured console application without overengineering

📌 Future Improvements

Input validation enhancements

Async/await instead of manual Task

Logging and exception handling

Unit testing

Simple UI (WPF / Web API)

👤 Author

Mohamed Mohyeldin Amr Hassan

Feel free to fork, explore, or suggest improvements ⭐
