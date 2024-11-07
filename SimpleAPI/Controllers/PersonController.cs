using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleAPI.Data;

namespace SimpleAPI.Controllers;

[Route("/v1")]
[ApiController]
public class PersonController : ControllerBase
{
    [HttpGet]
    [Route("/persons")]
    public async Task<IActionResult> GetAsync(AppDbContext context)
    {
        var persons = await context.Persons.AsNoTracking().ToListAsync();

        return Ok(persons);
    }
}