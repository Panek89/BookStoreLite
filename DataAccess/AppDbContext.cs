using BookStoreLite.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStoreLite.DataAccess;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
        new Book { Id = 100, Title = "C# Fundamentals", Author = "John Doe", Price = 99.99m, IsRare = false },
        new Book { Id = 101, Title = "ASP.NET Core in Action", Author = "Jane Smith", Price = 129.50m, IsRare = false },
        new Book { Id = 102, Title = "Entity Framework Core Guide", Author = "Mark Johnson", Price = 89.00m, IsRare = false },
        new Book { Id = 103, Title = "LINQ Deep Dive", Author = "Emily Davis", Price = 75.25m, IsRare = false },
        new Book { Id = 104, Title = "Azure for Developers", Author = "Michael Brown", Price = 150.00m, IsRare = true },
        new Book { Id = 105, Title = "Design Patterns in C#", Author = "Chris White", Price = 110.00m, IsRare = false },
        new Book { Id = 106, Title = "Clean Code Practices", Author = "Robert Martin", Price = 140.00m, IsRare = true },
        new Book { Id = 107, Title = "Microservices with .NET", Author = "Anna Green", Price = 120.00m, IsRare = false },
        new Book { Id = 108, Title = "Advanced SQL Server", Author = "David Wilson", Price = 95.00m, IsRare = false },
        new Book { Id = 109, Title = "React and TypeScript", Author = "Laura Taylor", Price = 130.00m, IsRare = false },
        new Book { Id = 110, Title = "Angular Signals Explained", Author = "Peter Harris", Price = 115.00m, IsRare = false },
        new Book { Id = 111, Title = "OAuth 2.0 and PKCE", Author = "Sophia Clark", Price = 160.00m, IsRare = true },
        new Book { Id = 112, Title = "Minimal APIs in .NET", Author = "Daniel Lewis", Price = 105.00m, IsRare = false },
        new Book { Id = 113, Title = "JavaScript Essentials", Author = "Olivia Walker", Price = 80.00m, IsRare = false },
        new Book { Id = 114, Title = "TypeScript Best Practices", Author = "James Hall", Price = 95.00m, IsRare = false },
        new Book { Id = 115, Title = "Cloud Security Basics", Author = "Grace Allen", Price = 170.00m, IsRare = true },
        new Book { Id = 116, Title = "EF Core Migrations", Author = "Henry Young", Price = 90.00m, IsRare = false },
        new Book { Id = 117, Title = "SQL Collation & Unicode", Author = "Isabella Scott", Price = 100.00m, IsRare = false },
        new Book { Id = 118, Title = "Postman & API Testing", Author = "Matthew King", Price = 85.00m, IsRare = false },
        new Book { Id = 119, Title = "Secure File Handling in Azure", Author = "Victoria Adams", Price = 155.00m, IsRare = true }
    );

    }

    public DbSet<Book> Books { get; set; }
}
