using Microsoft.AspNetCore.Mvc;

namespace ServiceRepositoryApi.Controller;

public class CategoryController : ApiBaseController 
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok("hello world");
    }
}