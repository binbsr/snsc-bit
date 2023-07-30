using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS.Data;

namespace PMS.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        PMSDbContext context = new PMSDbContext();
        var departments = context.Departments.ToList();
        return Ok(departments);
    }
}
