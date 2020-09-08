using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Persons.Commands
{
    public class UpdatePersonCommand : IRequest
    {
        public int Id { get; set; }

        public string Nickname { get; set; }
    }

    public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdatePersonCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Persons.FindAsync(request.Id); 

            if (entity == null)
            {
                throw new NotFoundException(nameof(Person), request.Id);
            }

            entity.Nickname = request.Nickname;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value; 
        }
    }
}
