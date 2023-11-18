using BookStoreServer.WebApi.Models;
using BookStoreServer.WebApi.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace BookStoreServer.WebApi.Context;

public class AppDbContext: DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer("Data Source=DESKTOP-3O4V1S5;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<BookCategory> BookCategories { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookCategory>().HasKey(o => new { o.BookId, o.CategoryId });



        modelBuilder.Entity<Book>().OwnsOne(o => o.Price, price =>
        {
            price.Property(p => p.Currency).HasMaxLength(5);
            price.Property(p => p.Value).HasColumnType("money");
        });


        modelBuilder.Entity<Category>().HasData(
            
             new Category { Id = 1, Name = "Aksiyon", IsActive = true, IsDelete = false },
             new Category { Id = 2, Name = "Macera", IsActive = true, IsDelete = false },
             new Category { Id = 3, Name = "Bilim Kurgu", IsActive = true, IsDelete = false },
             new Category { Id = 4, Name = "Sanat", IsActive = true, IsDelete = false },
             new Category { Id = 5, Name = "Spor", IsActive = true, IsDelete = false },
             new Category { Id = 6, Name = "Bilmece", IsActive = true, IsDelete = false },
             new Category { Id = 7, Name = "Dergi", IsActive = true, IsDelete = false },
             new Category { Id = 8, Name = "Polisiye", IsActive = true, IsDelete = false },
             new Category { Id = 9, Name = "Aşk", IsActive = true, IsDelete = false },
             new Category { Id = 10, Name = "Yazılım", IsActive = true, IsDelete = false }


            );


    }


    














}
