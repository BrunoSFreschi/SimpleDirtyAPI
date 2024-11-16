using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleAPI.Data;
using SimpleAPI.Models;
using SimpleAPI.ViewModels;

namespace SimpleAPI.Controllers;

[Route("v1")]
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

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromServices] AppDbContext context, [FromBody] CreatePersonViewModel personViewModel)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        Person person = new()
        {
            Adress = personViewModel.Adress,
            Name = personViewModel.Name,
            Phone = personViewModel.Phone,
        };

        try
        {
            await context.Persons.AddAsync(person);
            await context.SaveChangesAsync();

            return Created($"/persons/{person.Id}", person);
        }
        catch (Exception) { return BadRequest(); }
    }

    [HttpPut("persons/{id}")]
    public async Task<IActionResult> PutAsync([FromServices] AppDbContext context, [FromBody] CreatePersonViewModel model, [FromRoute] int id)
    {
        var person = await context.Persons.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        if (person == null) 
            return NotFound();

        try
        {
            person.Adress = model.Adress;
            person.Name = model.Name;
            person.Phone = model.Phone;

            context.Persons.Update(person);
            await context.SaveChangesAsync();

            return Ok();
        }
        catch (Exception) { return BadRequest(); }
    }
}