using MediatR;
using Microsoft.EntityFrameworkCore;
using RossBoiler.Application.Data;
using RossBoiler.Application.Models;

namespace RossBoiler.Application.Queries
{
    public class GetBoilerSeriesByheadQueryHandler : IRequestHandler<GetBoilerSeriesByheadQuery, BoilerSeries?>
    {
        private readonly ApplicationDbContext _context;

        public GetBoilerSeriesByheadQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BoilerSeries?> Handle(GetBoilerSeriesByheadQuery request, CancellationToken cancellationToken)
        {
            var item = await _context.BoilerSeries
                                     .FirstOrDefaultAsync(b => b.Head == request.Head, cancellationToken);

            if (item == null)
            {
                throw new KeyNotFoundException($"BoilerSeries with Head '{request.Head}' not found.");
            }

            return item;
        }
    }
}
