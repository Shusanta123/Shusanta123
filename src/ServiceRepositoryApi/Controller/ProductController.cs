using Microsoft.AspNetCore.Mvc;

namespace ServiceRepositoryApi.Controller;

public class ProductController : ApiBaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok("Hello World!");
    }
}