using Microsoft.AspNetCore.Mvc;

namespace ServiceRepositoryApi.Controller;


[ApiController]
[Route("api/[controller]")]
public abstract class ApiBaseController : ControllerBase // abstract so no class can be made of this class
{
   
}