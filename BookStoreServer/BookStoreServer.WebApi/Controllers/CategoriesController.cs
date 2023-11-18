using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Dtos;
using BookStoreServer.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreServer.WebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CategoriesController : ControllerBase
{

    AppDbContext context = new();



    [HttpPost]
    public IActionResult CreateCategory(CreateCategoryRequestDto requestDto)
    {

        var checkNameIsUnique = context.Categories.Any(o => o.Name ==requestDto.Name);

        if(checkNameIsUnique )
        {

        Category category = new()
        {
            Name = requestDto.Name,
            IsActive = true,
            IsDelete = false

        };

        context.Categories.Add(category);
        }


        context.SaveChanges();

        return NoContent();
    }


    [HttpGet]
    public IActionResult GetAll()
    {

        var categories = context.Categories.Where(o => o.IsActive == true && o.IsDelete == false)
            .OrderBy(o => o.Name).
            ToList();

        return Ok(categories);
    }

    [HttpGet("{id}")]
    public IActionResult RemoveCategoryById(int id)
    {
        var category = context.Categories.FirstOrDefault(c => c.Id == id);

        if (category == null)
        {
            return NotFound();
        }

        category.IsActive = false;
        context.SaveChanges();

        return NoContent();
    }

    [HttpPost]
    public IActionResult UpdateCategory(UpdateCategoryRequestDto updateCategoryRequest)
    {

        Category category = context.Categories.Find(updateCategoryRequest.Id);

        if(category is null)
        {
            return NotFound();
        }
       
            category.Name = updateCategoryRequest.Name;
        

        return NoContent();
    }






}