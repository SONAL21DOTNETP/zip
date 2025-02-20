using MediatR;
using RossBoiler.Application.Models;

namespace RossBoiler.Application.Queries
{
    public record GetCustomerBoilerByCustomerIdQuery(int CustomerId) : IRequest<CustomerBoiler>;
}