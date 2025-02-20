using MediatR;
using Microsoft.EntityFrameworkCore;
using RossBoiler.Application.Data;
using RossBoiler.Application.Models;

namespace RossBoiler.Application.Queries
{
    public class GetContactCentreByCustomerIdQueryHandler : IRequestHandler<GetContactCentreByCustomerIdQuery, ContactCentre>
    {
        private readonly ApplicationDbContext _context;

        public GetContactCentreByCustomerIdQueryHandler(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<ContactCentre> Handle(GetContactCentreByCustomerIdQuery request, CancellationToken cancellationToken)
        {
            var contactcentre = await _context.ContactCentres
                .FirstOrDefaultAsync(x => x.CustomerId == request.CustomerId, cancellationToken);

            return contactcentre ?? throw new KeyNotFoundException($"ContactCentre with Customer ID {request.CustomerId} not found");
        }
    }
}