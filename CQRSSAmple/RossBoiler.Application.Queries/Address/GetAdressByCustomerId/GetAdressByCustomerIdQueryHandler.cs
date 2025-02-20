using MediatR;
using Microsoft.EntityFrameworkCore;
using RossBoiler.Application.Data;
using RossBoiler.Application.Models;

namespace RossBoiler.Application.Queries
{
    public class GetAdressByCustomerIdQueryHandler : IRequestHandler<GetAdressByCustomerIdQuery, Address>
    {
        private readonly ApplicationDbContext _context;

        public GetAdressByCustomerIdQueryHandler(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Address> Handle(GetAdressByCustomerIdQuery request, CancellationToken cancellationToken)
        {
            var address = await _context.Addresses
                .FirstOrDefaultAsync(x => x.CustomerId == request.CustomerId, cancellationToken);

            return address ?? throw new KeyNotFoundException($"Address with Customer ID {request.CustomerId} not found");
        }
    }
}