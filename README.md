# Library Management System

A console-based library management system built with C# and Entity Framework Core, demonstrating essential database operations, relationships, and LINQ querying in a clean, structured architecture. This application showcases practical implementation of EF Core concepts for managing books, authors, borrowers, and borrowing transactions.

[![.NET](https://img.shields.io/badge/.NET-Latest-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-Latest-239120?logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![EF Core](https://img.shields.io/badge/EF%20Core-Latest-512BD4)](https://docs.microsoft.com/en-us/ef/core/)

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technology Stack](#technology-stack)
- [Project Structure](#project-structure)
- [Database Design](#database-design)
- [EF Core Concepts Demonstrated](#ef-core-concepts-demonstrated)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Project Purpose](#project-purpose)
- [Future Improvements](#future-improvements)
- [Author](#author)

---

## Overview

This Library Management System is a console application that provides complete functionality for managing a library's book inventory, author records, borrowers, and borrowing transactions. Built entirely with Entity Framework Core and LINQ, the application demonstrates professional data access patterns without relying on external frameworks or UI libraries.

The system handles:
- **Book Management** - Add, update, delete, and list books
- **Author Management** - Automatic author handling and associations
- **Borrowing System** - Track book checkouts and returns
- **Overdue Tracking** - Monitor books borrowed for more than 14 days
- **Pagination** - Efficient data display for large datasets

---

## Features

### Core Functionality

**📖 Book Management**
- Add new books to the library catalog
- Update existing book information
- Delete books from the system
- List all books with pagination support

**✍️ Author Management**
- Automatic author creation and association
- Author-book relationship handling
- Maintain author records linked to books

**👤 Borrower & Borrowing System**
- Register borrowers in the system
- Borrow books with transaction tracking
- Return books and update availability
- Maintain borrowing history

**⏰ Overdue Book Tracking**
- Identify books borrowed for over 14 days
- Paginated overdue book listing
- Automatic overdue calculation

**📄 Pagination**
- Efficient listing for books
- Paginated overdue records
- Optimized data retrieval for large datasets

**🧠 LINQ-Based Queries**
- Advanced filtering and data retrieval
- Clean, readable query syntax
- Type-safe database operations

**⚡ Performance Optimization**
- `AsNoTracking()` for read-only operations
- Efficient query execution
- Optimized database access patterns

---

## Technology Stack

### Core Technologies
- **C#** - Primary programming language
- **.NET** - Runtime framework
- **Entity Framework Core** - Object-relational mapper
- **LINQ** - Language Integrated Query for data operations

### Application Type
- **Console Application** - Interactive command-line interface

### Development Approach
- No external frameworks or UI libraries
- Pure EF Core and LINQ implementation
- Clean, structured architecture

---

## Project Structure

```
LibraryEFCoreProj/
│
├── Models/                        # Domain Entities
│   ├── Book.cs                   # Book entity
│   ├── Author.cs                 # Author entity
│   ├── Borrower.cs               # Borrower entity
│   └── Borrowing.cs              # Borrowing transaction entity
│
├── LibraryContext/               # Data Access Layer
│   └── AppDBContext.cs           # EF Core DbContext
│
├── Library.cs                    # Business Logic
│   └── Main application logic & interactive menu
│
└── Program.cs                    # Application Entry Point
```

### Component Responsibilities

| Component | Responsibility |
|-----------|---------------|
| **Models** | Domain entities representing database tables |
| **AppDBContext** | EF Core context managing database connections and entity configurations |
| **Library.cs** | Business logic, menu system, and user interaction |
| **Program.cs** | Application bootstrapping and initialization |

---

## Database Design

The application uses a relational database design with the following structure:

### Entity Relationships

**Book → Author**
- Each book belongs to one author
- Authors can have multiple books
- One-to-Many relationship

**Borrowing ↔ Book & Borrower**
- Links books with borrowers
- Tracks borrowing transactions
- Many-to-Many relationship via junction table

**Borrower → Borrowings**
- Each borrower can have multiple borrowings
- One-to-Many relationship

### Entity Framework Core Handles

- **Relationships** - Automatic foreign key management
- **Foreign Keys** - Referential integrity enforcement
- **Data Persistence** - CRUD operations and change tracking
- **Navigation Properties** - Relationship traversal

---

## EF Core Concepts Demonstrated

This project showcases the following Entity Framework Core and LINQ concepts:

### Entity Framework Core

- **DbContext and DbSet**
  - Database connection management
  - Entity set definitions
  - Change tracking

- **CRUD Operations**
  - Create (Add)
  - Read (Query)
  - Update (Modify)
  - Delete (Remove)

- **Navigation Properties**
  - `Include()` for eager loading
  - Related entity access
  - Relationship traversal

- **Performance Optimization**
  - `AsNoTracking()` for read-only queries
  - Reduced memory overhead
  - Improved query performance

- **Entity State Tracking**
  - Entity state management
  - Change detection
  - Update handling

### LINQ Queries

- **Where** - Filtering data
- **Single** - Retrieving single entities
- **First** - Getting first matching element
- **Skip** - Pagination offset
- **Take** - Pagination limit
- **OrderBy/ThenBy** - Sorting operations

---

## Getting Started

Follow these steps to set up and run the project on your local machine.

### Prerequisites

- **.NET SDK** (latest version)
- **Visual Studio** 2022 or later (or any compatible IDE)
- **SQL Server** (LocalDB, Express, or full version)

### Installation

**1. Clone the Repository**

```bash
git clone https://github.com/your-username/LibraryEFCoreProj.git
```

**2. Open in Visual Studio**

Open the solution file (`.sln`) in Visual Studio.

**3. Configure Database Connection**

Update the connection string in `AppDBContext.cs`:

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer("YOUR_CONNECTION_STRING");
}
```

**4. Apply Database Migrations**

Run in Package Manager Console:

```powershell
Update-Database
```

Or using .NET CLI:

```bash
dotnet ef database update
```

**5. Run the Application**

Press `F5` in Visual Studio or run:

```bash
dotnet run
```

---

## Usage

### Interactive Console Menu

Upon running the application, you'll be presented with an interactive menu:

```
╔════════════════════════════════════════╗
║     Library Management System          ║
╚════════════════════════════════════════╝

1- Add a book
2- List all books
3- Update a book
4- Delete a book
5- Borrow a book
6- Return a book
7- List overdue books
8- Exit

Enter your choice:
```

### Menu Options

| Option | Function |
|--------|----------|
| **1** | Add a new book to the library |
| **2** | Display all books with pagination |
| **3** | Update existing book information |
| **4** | Remove a book from the system |
| **5** | Record a book borrowing transaction |
| **6** | Process a book return |
| **7** | View books overdue (>14 days) |
| **8** | Exit the application |

### Sample Workflow

1. **Add a Book** - Enter book details and author information
2. **List Books** - Browse through paginated book catalog
3. **Borrow Book** - Select a book and borrower to create transaction
4. **Check Overdue** - View all books borrowed for more than 14 days
5. **Return Book** - Process return and update availability

---

## Project Purpose

This application was developed to:

- **Practice Entity Framework Core** - Hands-on experience with EF Core fundamentals
- **Strengthen LINQ Skills** - Master querying and data manipulation
- **Understand Relationships** - Implement one-to-many and many-to-many relationships
- **Build Structured Applications** - Create clean, maintainable console applications
- **Avoid Over-engineering** - Focus on core concepts without unnecessary complexity

The project serves as a practical demonstration of database-first development using modern .NET data access technologies.

---

## Future Improvements

Potential enhancements for the application:

- **Input Validation** - Comprehensive user input validation and error handling
- **Async/Await** - Convert operations to asynchronous for better performance
- **Logging** - Implement structured logging for debugging and monitoring
- **Exception Handling** - Robust error handling and user-friendly messages
- **Unit Testing** - Add test coverage for business logic
- **User Interface** - Develop WPF desktop app or Web API for modern UI

---

## Author

**Mohamed Mohyeldin Amr Hassan**

Feel free to fork, explore, or suggest improvements ⭐

---

## License

This project is available for educational and demonstration purposes.

---

**Note:** This is an educational project demonstrating Entity Framework Core and LINQ concepts in a practical application.
