using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryEFCoreProj.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Borrowers",
                columns: table => new
                {
                    BorrowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowers", x => x.BorrowerId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    PublicationYear = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Borrowings",
                columns: table => new
                {
                    BorrowingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BorrowerId = table.Column<int>(type: "int", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowings", x => x.BorrowingId);
                    table.ForeignKey(
                        name: "FK_Borrowings_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrowings_Borrowers_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "Borrowers",
                        principalColumn: "BorrowerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 1, "J.K. Rowling" },
                    { 2, "J.R.R. Tolkien" },
                    { 3, "George Orwell" },
                    { 4, "Agatha Christie" },
                    { 5, "Jane Austen" },
                    { 6, "Stephen King" },
                    { 7, "Isaac Asimov" },
                    { 8, "Virginia Woolf" },
                    { 9, "Ernest Hemingway" },
                    { 10, "Toni Morrison" },
                    { 11, "Charles Dickens" },
                    { 12, "Emily Brontë" },
                    { 13, "F. Scott Fitzgerald" },
                    { 14, "Gabriel García Márquez" },
                    { 15, "Mark Twain" },
                    { 16, "Mary Shelley" },
                    { 17, "Ray Bradbury" },
                    { 18, "Leo Tolstoy" },
                    { 19, "Harper Lee" },
                    { 20, "Salman Rushdie" }
                });

            migrationBuilder.InsertData(
                table: "Borrowers",
                columns: new[] { "BorrowerId", "Name" },
                values: new object[,]
                {
                    { 1, "Alice Smith" },
                    { 2, "Bob Johnson" },
                    { 3, "Carol Williams" },
                    { 4, "David Brown" },
                    { 5, "Emma Davis" },
                    { 6, "Frank Wilson" },
                    { 7, "Grace Taylor" },
                    { 8, "Henry Moore" },
                    { 9, "Isabella Clark" },
                    { 10, "James Lee" },
                    { 11, "Katherine Adams" },
                    { 12, "Liam Harris" },
                    { 13, "Mia Lewis" },
                    { 14, "Noah Walker" },
                    { 15, "Olivia Young" },
                    { 16, "Peter Allen" },
                    { 17, "Quinn Baker" },
                    { 18, "Rachel Carter" },
                    { 19, "Samuel Evans" },
                    { 20, "Tara Green" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "PublicationYear", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1997, "Harry Potter and the Philosopher's Stone" },
                    { 2, 1, 1998, "Harry Potter and the Chamber of Secrets" },
                    { 3, 1, 1999, "Harry Potter and the Prisoner of Azkaban" },
                    { 4, 1, 2000, "Harry Potter and the Goblet of Fire" },
                    { 5, 1, 2003, "Harry Potter and the Order of the Phoenix" },
                    { 6, 2, 1954, "The Lord of the Rings: The Fellowship of the Ring" },
                    { 7, 2, 1954, "The Lord of the Rings: The Two Towers" },
                    { 8, 2, 1955, "The Lord of the Rings: The Return of the King" },
                    { 9, 2, 1937, "The Hobbit" },
                    { 10, 2, 1977, "The Silmarillion" },
                    { 11, 3, 1949, "1984" },
                    { 12, 3, 1945, "Animal Farm" },
                    { 13, 3, 1938, "Homage to Catalonia" },
                    { 14, 4, 1934, "Murder on the Orient Express" },
                    { 15, 4, 1939, "And Then There Were None" },
                    { 16, 4, 1926, "The Murder of Roger Ackroyd" },
                    { 17, 4, 1937, "Death on the Nile" },
                    { 18, 5, 1813, "Pride and Prejudice" },
                    { 19, 5, 1811, "Sense and Sensibility" },
                    { 20, 5, 1815, "Emma" },
                    { 21, 5, 1817, "Persuasion" },
                    { 22, 6, 1977, "The Shining" },
                    { 23, 6, 1986, "It" },
                    { 24, 6, 1974, "Carrie" },
                    { 25, 6, 1987, "Misery" },
                    { 26, 7, 1951, "Foundation" },
                    { 27, 7, 1952, "Foundation and Empire" },
                    { 28, 7, 1953, "Second Foundation" },
                    { 29, 7, 1950, "I, Robot" },
                    { 30, 8, 1925, "Mrs Dalloway" },
                    { 31, 8, 1927, "To the Lighthouse" },
                    { 32, 8, 1928, "Orlando" },
                    { 33, 8, 1931, "The Waves" },
                    { 34, 9, 1952, "The Old Man and the Sea" },
                    { 35, 9, 1929, "A Farewell to Arms" },
                    { 36, 9, 1940, "For Whom the Bell Tolls" },
                    { 37, 10, 1987, "Beloved" },
                    { 38, 10, 1977, "Song of Solomon" },
                    { 39, 10, 1992, "Jazz" },
                    { 40, 11, 1859, "A Tale of Two Cities" },
                    { 41, 11, 1861, "Great Expectations" },
                    { 42, 11, 1838, "Oliver Twist" },
                    { 43, 12, 1847, "Wuthering Heights" },
                    { 44, 13, 1925, "The Great Gatsby" },
                    { 45, 13, 1934, "Tender is the Night" },
                    { 46, 14, 1967, "One Hundred Years of Solitude" },
                    { 47, 14, 1985, "Love in the Time of Cholera" },
                    { 48, 15, 1876, "The Adventures of Tom Sawyer" },
                    { 49, 15, 1884, "Adventures of Huckleberry Finn" },
                    { 50, 16, 1818, "Frankenstein" },
                    { 51, 16, 1826, "The Last Man" },
                    { 52, 17, 1953, "Fahrenheit 451" },
                    { 53, 17, 1950, "The Martian Chronicles" },
                    { 54, 18, 1865, "War and Peace" },
                    { 55, 18, 1877, "Anna Karenina" },
                    { 56, 19, 1960, "To Kill a Mockingbird" },
                    { 57, 20, 1981, "Midnight’s Children" },
                    { 58, 20, 1988, "Satanic Verses" },
                    { 59, 1, 2007, "Harry Potter and the Deathly Hallows" },
                    { 60, 1, 2012, "The Casual Vacancy" },
                    { 61, 2, 2007, "Children of Hurin" },
                    { 62, 3, 1936, "Keep the Aspidistra Flying" },
                    { 63, 4, 1936, "The ABC Murders" },
                    { 64, 5, 1814, "Mansfield Park" },
                    { 65, 6, 1975, "Salem’s Lot" },
                    { 66, 7, 1954, "The Caves of Steel" },
                    { 67, 8, 1929, "A Room of One’s Own" },
                    { 68, 9, 1926, "The Sun Also Rises" },
                    { 69, 10, 1997, "Paradise" },
                    { 70, 11, 1850, "David Copperfield" },
                    { 71, 12, 1847, "Agnes Grey" },
                    { 72, 13, 1920, "This Side of Paradise" },
                    { 73, 14, 1981, "Chronicle of a Death Foretold" },
                    { 74, 15, 1881, "The Prince and the Pauper" },
                    { 75, 16, 1819, "Mathilda" },
                    { 76, 17, 1962, "Something Wicked This Way Comes" },
                    { 77, 18, 1899, "Resurrection" },
                    { 78, 19, 2015, "Go Set a Watchman" },
                    { 79, 20, 1983, "Shame" },
                    { 80, 1, 2005, "Harry Potter and the Half-Blood Prince" },
                    { 81, 2, 2017, "Beren and Lúthien" },
                    { 82, 3, 1939, "Coming Up for Air" },
                    { 83, 4, 1941, "Evil Under the Sun" },
                    { 84, 5, 1817, "Northanger Abbey" },
                    { 85, 6, 2013, "Doctor Sleep" },
                    { 86, 7, 1957, "The Naked Sun" },
                    { 87, 8, 1933, "Flush" },
                    { 88, 9, 1950, "Across the River and Into the Trees" },
                    { 89, 10, 1981, "Tar Baby" },
                    { 90, 11, 1853, "Bleak House" },
                    { 91, 12, 1848, "The Tenant of Wildfell Hall" },
                    { 92, 13, 1922, "The Beautiful and Damned" },
                    { 93, 14, 1975, "The Autumn of the Patriarch" },
                    { 94, 15, 1889, "A Connecticut Yankee in King Arthur’s Court" },
                    { 95, 16, 1823, "Valperga" },
                    { 96, 17, 1957, "Dandelion Wine" },
                    { 97, 18, 1886, "The Death of Ivan Ilyich" },
                    { 98, 20, 1999, "The Ground Beneath Her Feet" },
                    { 99, 11, 1854, "Hard Times" },
                    { 100, 20, 1995, "The Moor’s Last Sigh" }
                });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "BorrowingId", "BookId", "BorrowDate", "BorrowerId", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 2, 1, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 4, 3, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null },
                    { 6, 5, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 6, new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null },
                    { 8, 7, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 8, new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, null },
                    { 10, 9, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 10, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null },
                    { 12, 11, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 12, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, null },
                    { 14, 13, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 14, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, null },
                    { 16, 15, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 16, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, null },
                    { 18, 17, new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 18, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, null },
                    { 20, 19, new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 20, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 22, 21, new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 22, new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 24, 23, new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 24, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null },
                    { 26, 25, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 26, new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null },
                    { 28, 27, new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 28, new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, null },
                    { 30, 29, new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 30, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null },
                    { 32, 31, new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 32, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, null },
                    { 34, 33, new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 34, new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, null },
                    { 36, 35, new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 36, new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, null },
                    { 38, 37, new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 38, new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, null },
                    { 40, 39, new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 40, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 42, 41, new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 42, new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 44, 43, new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 44, new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null },
                    { 46, 45, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 46, new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null },
                    { 48, 47, new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 48, new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, null },
                    { 50, 49, new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 50, new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null },
                    { 52, 51, new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 52, new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, null },
                    { 54, 53, new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new DateTime(2025, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 54, new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, null },
                    { 56, 55, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 56, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, null },
                    { 58, 57, new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 58, new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, null },
                    { 60, 59, new DateTime(2025, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowings_BookId",
                table: "Borrowings",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowings_BorrowerId",
                table: "Borrowings",
                column: "BorrowerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrowings");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Borrowers");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
