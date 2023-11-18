using BookStoreServer.WebApi.ValueObjects;

namespace BookStoreServer.WebApi.Models;

public sealed class Book
{

    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; }
    public string Summary { get; set; }
    public Money Price { get; set; } = new Money(0m , "₺");
    public string CoverImageUrl { get; set; }
    public int Quantity { get; set; }
    public string ISBN { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }






}
