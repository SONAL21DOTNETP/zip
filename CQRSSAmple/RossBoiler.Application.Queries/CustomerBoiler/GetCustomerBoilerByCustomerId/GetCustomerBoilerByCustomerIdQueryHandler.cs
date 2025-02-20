using MediatR;
using Microsoft.EntityFrameworkCore;
using RossBoiler.Application.Data;
using RossBoiler.Application.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RossBoiler.Application.Queries
{
    public class GetCustomerBoilerByCustomerIdQueryHandler : IRequestHandler<GetCustomerBoilerByCustomerIdQuery, CustomerBoiler>
    {
        private readonly ApplicationDbContext _context;

        public GetCustomerBoilerByCustomerIdQueryHandler(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<CustomerBoiler> Handle(GetCustomerBoilerByCustomerIdQuery request, CancellationToken cancellationToken)
        {
            var customerBoiler = await _context.CustomerBoilers
                .FirstOrDefaultAsync(x => x.CustomerId == request.CustomerId, cancellationToken);

            return customerBoiler ?? throw new KeyNotFoundException($"CustomerBoiler with Customer ID {request.CustomerId} not found");
        }
    }
}