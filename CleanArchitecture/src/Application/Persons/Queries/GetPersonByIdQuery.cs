using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Persons.Queries
{
    public class GetPersonByIdQuery : IRequest<Person>
    {
        public int Id { get; set; }
    }

    public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, Person>
    {

        private readonly IApplicationDbContext _context;

        public GetPersonByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var person = await _context.Persons.FindAsync(request.Id);
            return person;
        }
    }
}
