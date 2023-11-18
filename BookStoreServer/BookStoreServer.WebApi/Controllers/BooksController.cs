using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Dtos;
using BookStoreServer.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using static Azure.Core.HttpHeader;

namespace BookStoreServer.WebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BooksController : ControllerBase
{
    [HttpPost]
    public IActionResult GetAll(RequestDto requestDto)
    {

        AppDbContext appDbContext = new();

        List<Book> books = new();


   if(requestDto.CategoryId is null){


         books = appDbContext.Books.Where(p => p.IsActive == true && p.IsDelete== false).
            Where(p => p.Title.ToLower().Contains(requestDto.Search.ToLower())
            || 
            p.ISBN.ToLower().Contains(requestDto.Search.ToLower())             
            ||
            p.Author.ToLower().Contains(requestDto.Search.ToLower()))
            .Take(requestDto.PageSize)
            .OrderByDescending(p=> p.CreateAt)
           
            .ToList();
        }
        else
        {


            books = appDbContext.BookCategories.Where(o => o.CategoryId == requestDto.CategoryId)
                .Include(o => o.Book)
                .Select(p => p.Book)
                .Where(p => p.IsActive == true && p.IsDelete == false)
                 .Where(p => p.Title.ToLower().Contains(requestDto.Search.ToLower())
                    ||
                        p.ISBN.ToLower().Contains(requestDto.Search.ToLower())
                    ||
                        p.Author.ToLower().Contains(requestDto.Search.ToLower()))
                 .Take(requestDto.PageSize)
                 .OrderByDescending(p => p.CreateAt)
                  .ToList();

        }


        return Ok(books);    
    
 }

    [HttpGet("name")] 
    public IActionResult GetName()
    {
        string name = "Hello";

        return Ok(name);
    }





}



