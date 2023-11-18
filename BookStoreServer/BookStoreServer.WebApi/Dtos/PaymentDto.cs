using BookStoreServer.WebApi.Models;

namespace BookStoreServer.WebApi.Dtos
{
    public sealed record PaymentDto(
        List<Book> Books
        );
    
}
