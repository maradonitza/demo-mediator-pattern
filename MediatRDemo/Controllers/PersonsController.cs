using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRDemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediatRDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IMediator mediator;
        public PersonsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<Person> GetPerson([FromRoute] RequestQuery query) => await this.mediator.Send(query);

        public class RequestQuery: IRequest<Person>
        {
            public int Id { get; set; }
        }

        public class PersonHandler : IRequestHandler<RequestQuery, Person>
        {
            private MyDatabaseContext db;
            public PersonHandler(MyDatabaseContext db) => this.db = db;

            public Task<Person> Handle(RequestQuery request, CancellationToken cancellationToken)
            {
                return this.db.Persons.Where(p => p.Id == request.Id).SingleOrDefaultAsync();
            }
        }
    }
}
