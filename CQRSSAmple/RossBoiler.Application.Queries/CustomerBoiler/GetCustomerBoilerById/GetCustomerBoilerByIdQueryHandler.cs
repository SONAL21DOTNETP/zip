using MediatR;
using Microsoft.EntityFrameworkCore;
using RossBoiler.Application.Data;
using RossBoiler.Application.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RossBoiler.Application.Queries
{
    public class GetCustomerBoilerByIdQueryHandler : IRequestHandler<GetCustomerBoilerByIdQuery, CustomerBoiler>
    {
        private readonly ApplicationDbContext _context;

        public GetCustomerBoilerByIdQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CustomerBoiler> Handle(GetCustomerBoilerByIdQuery request, CancellationToken cancellationToken)
        {
            var item= await _context.CustomerBoilers.FindAsync(new object[] { request.Id }, cancellationToken);
            if (item == null)
            {

                throw new KeyNotFoundException($"CustomerBoiler with ID {request.Id} not found");

            }
            return item;
        }
    }
}
