using CleanArchitecture.Application.Persons.Commands;
using CleanArchitecture.Application.Persons.Queries;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ApiController
    {
        [HttpGet("{id}")]
        public async Task<Person> Get(int id)
        {
            return await Mediator.Send(new GetPersonByIdQuery { Id = id });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdatePersonCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }
    }
}
