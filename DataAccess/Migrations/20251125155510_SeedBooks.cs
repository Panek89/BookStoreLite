using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreLite.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "IsRare", "Price", "Title" },
                values: new object[,]
                {
                    { 100, "John Doe", false, 99.99m, "C# Fundamentals" },
                    { 101, "Jane Smith", false, 129.50m, "ASP.NET Core in Action" },
                    { 102, "Mark Johnson", false, 89.00m, "Entity Framework Core Guide" },
                    { 103, "Emily Davis", false, 75.25m, "LINQ Deep Dive" },
                    { 104, "Michael Brown", true, 150.00m, "Azure for Developers" },
                    { 105, "Chris White", false, 110.00m, "Design Patterns in C#" },
                    { 106, "Robert Martin", true, 140.00m, "Clean Code Practices" },
                    { 107, "Anna Green", false, 120.00m, "Microservices with .NET" },
                    { 108, "David Wilson", false, 95.00m, "Advanced SQL Server" },
                    { 109, "Laura Taylor", false, 130.00m, "React and TypeScript" },
                    { 110, "Peter Harris", false, 115.00m, "Angular Signals Explained" },
                    { 111, "Sophia Clark", true, 160.00m, "OAuth 2.0 and PKCE" },
                    { 112, "Daniel Lewis", false, 105.00m, "Minimal APIs in .NET" },
                    { 113, "Olivia Walker", false, 80.00m, "JavaScript Essentials" },
                    { 114, "James Hall", false, 95.00m, "TypeScript Best Practices" },
                    { 115, "Grace Allen", true, 170.00m, "Cloud Security Basics" },
                    { 116, "Henry Young", false, 90.00m, "EF Core Migrations" },
                    { 117, "Isabella Scott", false, 100.00m, "SQL Collation & Unicode" },
                    { 118, "Matthew King", false, 85.00m, "Postman & API Testing" },
                    { 119, "Victoria Adams", true, 155.00m, "Secure File Handling in Azure" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 119);
        }
    }
}
