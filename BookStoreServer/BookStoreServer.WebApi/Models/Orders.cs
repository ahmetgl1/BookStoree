using BookStoreServer.WebApi.ValueObjects;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreServer.WebApi.Models;

public sealed  class Orders
{
    public int Id { get; set; }
    public string OrderNumber { get; set; } //16 hane unieque
  
    [ForeignKey("Book")]
    public int BookId { get; set; }
    public Book Book { get; set; }
    public Money Price { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentType { get; set; }
    public string PaymentNumber { get; set; }




    public static string SetNewOrderNumber()
    {



        return Guid.NewGuid().ToString();
    }







}
