using BookStoreServer.WebApi.Models;

namespace BookStoreServer.WebApi.Dtos;

public sealed  class ResponseDto<T>
{
    public T Data { get; set; }    
    public int PageSize { get; set; }   //sayfada bulunacak sayfa sayısı
    public int PageNumber { get; set; }  // sayfa numarası 

    public int TotalPageCount { get; set; }  //toplam sayfa numarası
    public bool IsFirstPage { get; set; } // ilk sayfa mı
    public bool IsLastPage { get; set; } //son sayfa mı







}
