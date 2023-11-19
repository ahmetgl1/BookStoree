using BookStoreServer.WebApi.Models;
using Iyzipay.Model;

namespace BookStoreServer.WebApi.Dtos
{
    public sealed record PaymentDto(
          List<Book> Books,
          Buyer Buyer,
          Address shippingAddress,
          Address billingAddress,
          PaymentCard PaymentCard
        );
    
}
