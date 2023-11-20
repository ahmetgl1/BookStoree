using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Dtos;
using BookStoreServer.WebApi.Models;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreServer.WebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public sealed class ShoppingCartsController : ControllerBase
{

  

    [HttpPost]
    public IActionResult Payment(PaymentDto requestDto)
    {


        decimal total = 0;
        decimal commision = 0;
        foreach (var book in requestDto.Books )
        {
            total += book.Price.Value;
            
        }
        commision = total;


        Currency currency = Currency.TRY;
        string requestCurrency = requestDto.Books[0]?.Price.Currency;


        if(!string.IsNullOrEmpty(requestCurrency) )
        {


            switch (requestCurrency)
            {
                case "₺":

                    currency = Currency.TRY;
                    break;
                case "$":

                    currency = Currency.USD;
                    break;

                case "£":

                    currency = Currency.EUR;
                    break;

                default:
                    throw new Exception("Para Birimi Bulunamadı");
                    break;
            }

        }



        Options options = new Options();
        options.ApiKey = "sandbox-W7wbQ7QdFIhY9N4rV6TSVGWdvuW5u6ac";
        options.SecretKey = "sandbox-TSddGptrgR4Q6W5zzanfyXXxyJ3qG5H8";
        options.BaseUrl = "https://sandbox-api.iyzipay.com";

        CreatePaymentRequest request = new CreatePaymentRequest();
        request.Locale = Locale.TR.ToString();
        request.ConversationId = Orders.SetNewOrderNumber(); //birden fazla aynı isteği engellemek için oluşturulan ID değer
        request.Price = total.ToString(); //ödeme tutarı
        request.PaidPrice = commision.ToString(); // komisyon ile ödeme tutarı toplamı 
        request.Currency = currency.ToString();
        request.Installment = 1;
        request.BasketId = "B67832";
        request.PaymentChannel = PaymentChannel.WEB.ToString();
        request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

        PaymentCard paymentCard = requestDto.PaymentCard;
        request.PaymentCard = paymentCard;

        Buyer buyer = requestDto.Buyer;
        buyer.Id = Guid.NewGuid().ToString();
        request.Buyer = buyer;

        Address shippingAddress = requestDto.shippingAddress;
        request.ShippingAddress = shippingAddress;

        Address billingAddress = requestDto.billingAddress;
        request.BillingAddress = billingAddress;


        List<BasketItem> basketItems = new List<BasketItem>();
        foreach(var book in requestDto.Books)
        {
            
            BasketItem item = new BasketItem();

            item.Category1 = "Book";
            item.Category2 = "Book";
            item.Id = book.Id.ToString();
            item.Name = book.Title;
            item.ItemType = BasketItemType.PHYSICAL.ToString();
            item.Price = book.Price.Value.ToString();

            basketItems.Add(item);

        }
        request.BasketItems = basketItems;
      
    
        Payment payment = Iyzipay.Model.Payment.Create(request, options);


        if (payment.Status == "success")
        {

            List<Orders> orders = new();

            foreach (var book in requestDto.Books)
            {
                Orders order = new()
                {
                   
                    OrderNumber = request.BasketId,
                    BookId = book.Id,
                    Price = new ValueObjects.Money(book.Price.Value, book.Price.Currency),
                    PaymentDate = DateTime.Now,
                    PaymentType = "Credit Card",
                    PaymentNumber = payment.PaymentId
                    
                };
                    orders.Add(order);
                
            }

            AppDbContext _appDbContext = new();

            _appDbContext.AddRange(orders);
            _appDbContext.SaveChanges();


            return NoContent();

        }
        else
        {
            return BadRequest(payment.ErrorMessage);
        }

    }





}
