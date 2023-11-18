using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreServer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationsController : ControllerBase
    {
        private readonly AppDbContext _context = new AppDbContext();

        [HttpGet]
        public IActionResult SeedData()
        {
            List<Book> books = new List<Book>();
            for (int i = 1; i <= 100; i++)
            {
                var book = new Book()
                {
                    Title = "Kitap" + i,
                    Author = "Ahmet Güzeller",
                    Summary = "Summary" + i,
                    CoverImageUrl = "http://exprostudio.com/html/book_library/images/books/img-06.jpg",
                    CreateAt = DateTime.Now,
                    IsActive = true,
                    IsDelete = false,
                    Price = new ValueObjects.Money(i, "₺"),
                    Quantity = 10,
                    ISBN = "782-454-961-4" + i,
                    UpdateAt = DateTime.Now
                };
                books.Add(book);
            }
            _context.Books.AddRange(books);
            _context.SaveChanges();

            // BookCategory ilişkilerini oluştur ve ekle
            List<BookCategory> bookCategories = new List<BookCategory>();
            var random = new Random();
            var allCategories = _context.Categories.ToList(); // Tüm kategorileri al

            foreach (var book in books)
            {
                var randomCategory = allCategories[random.Next(0, allCategories.Count)]; // Tüm kategoriler arasından rastgele bir kategori seç
                var bookCategory = new BookCategory()
                {
                    BookId = book.Id,
                    CategoryId = randomCategory.Id
                };
                bookCategories.Add(bookCategory);
            }
            _context.BookCategories.AddRange(bookCategories);
            _context.SaveChanges();

            return Ok();
        }
    }
}
