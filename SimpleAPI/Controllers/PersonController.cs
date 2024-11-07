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
    public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
    {
        var persons = await context.Persons.AsNoTracking().ToListAsync();

        return Ok(persons);
    }

    [HttpGet]
    [Route("/persons/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromServices] AppDbContext context, [FromRoute] int id)
    {
        var person = await context.Persons.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        return person == null ? NotFound() : Ok(person);
    }
}